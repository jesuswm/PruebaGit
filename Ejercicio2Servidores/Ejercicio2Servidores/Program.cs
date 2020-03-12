using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Ejercicio2Servidores
{
    class Program
    {
        static readonly object l=new object();
        static string mensage;
        static List<StreamWriter> writers=new List<StreamWriter>();
        static List<string> usuarios=new List<string>();
        static int conectados = 0;
        delegate void delegado(StreamWriter sw, String nombreUsuario, IPEndPoint ieClient, string msg);
        public void MandarMensajes(StreamWriter sw,String nombreUsuario, IPEndPoint ieClient, string msg) {
            lock (l)
            {
                foreach (StreamWriter writer in writers)
                {
                    if (writer != sw)
                    {
                        writer.WriteLine($"{nombreUsuario}@{ieClient.Address}: {msg}");
                        writer.Flush();
                    }
                }
            }
        }
        public static bool comandos(string valor,StreamWriter sw,out bool fin)
        {
            switch (valor)
            {
                case null:
                    fin = true;
                    return true;
                    break;
                case "#salir":
                    fin = true;
                    return true;
                    break;
                case "#lista":
                    sw.WriteLine("Lista de Usuarios:");
                    sw.Flush();
                    lock (l)
                    {
                        foreach (string user in usuarios)
                        {
                            sw.WriteLine(user);
                            sw.Flush();
                        }
                    }
                    sw.WriteLine("----------");
                    sw.Flush();
                    fin = false;
                    return true;
                    break;
                default:
                    fin = false;
                    return false;
                    break;
            }
        }
        static void Main(string[] args)
        {
            //31416
            bool encendido = true;
            int port =1;
            bool valido = false;
            Socket socket = null;
            while (!valido)
            {
                try { 
                    IPEndPoint ie = new IPEndPoint(IPAddress.Any, port);
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Bind(ie);
                    socket.Listen(10);
                    valido = true;
                    Console.WriteLine($"Port {port} free");
                }catch (System.Net.Sockets.SocketException) { port++; }
            }
            while (encendido)
            {
            
                    conectados++;
                    Socket sclient = socket.Accept();
                    new Thread(funcionHilo).Start(sclient);
            }
            socket.Close();
        }
        public static void funcionHilo(Object socket){
            if(socket is Socket)
            {
                String nombreUsuario=null;
                bool fin=false;
                bool introdujoUsuario=false;
                bool usuarioValido = false;
                Socket sclient = ((Socket)socket);
                IPEndPoint ieClient = (IPEndPoint)sclient.RemoteEndPoint;
                Console.WriteLine($"Se ha conectado desde {ieClient.Address}");
                NetworkStream ns = new NetworkStream(sclient);
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);
                sw.WriteLine("Bienvenido al chat introduzca su nombre de usuario");
                sw.Flush();
                while (!usuarioValido && !fin)
                {
                    try
                    {
                        nombreUsuario = sr.ReadLine();
                    }
                    catch (System.IO.IOException)
                    {
                        nombreUsuario = null;
                    }
                    
                    if (!comandos(nombreUsuario, sw,out fin))
                    {
                        fin = false;
                        lock (l)
                        {
                            if (!usuarios.Contains(nombreUsuario))
                            {
                                usuarioValido = true;
                                usuarios.Add(nombreUsuario);
                                introdujoUsuario = true;
                                Console.WriteLine($"Se ha establecido el usuario {nombreUsuario}@{ieClient.Address}");
                                writers.Add(sw);
                                foreach (StreamWriter writer in writers)
                                {
                                    writer.WriteLine($"Se ha conectado {nombreUsuario}@{ieClient.Address}");
                                    writer.Flush();
                                }
                            }
                            else
                            {
                                sw.WriteLine("Ese nombre de usuario no esta disponible introduzca otro");
                                sw.Flush();
                            }
                        }
                    }
                }
                //sw.WriteLine("Se ha conectado el Usuario@" + ieClient.Address);
                //sw.Flush();
                while (!fin)
                {
                    try
                    {
                        String msg = sr.ReadLine();
                        
                        if (!comandos(msg, sw, out fin))
                        {
                            lock (l)
                            {
                                foreach (StreamWriter writer in writers)
                                {
                                    if (writer != sw)
                                    {
                                        writer.WriteLine($"{nombreUsuario}@{ieClient.Address}: {msg}");
                                        writer.Flush();
                                    }
                                }
                            }
                        }
                    }
                    catch (System.IO.IOException) { fin = true; }
                }
                if (introdujoUsuario)
                {
                    lock (l)
                    {
                        usuarios.Remove(nombreUsuario);
                        writers.Remove(sw);
                        foreach (StreamWriter writer in writers)
                        {
                            writer.WriteLine($"Se ha desconectado el {nombreUsuario}@{ieClient.Address}");
                            writer.Flush();
                        }
                    }
                }
                lock (l)
                {
                    conectados--;
                }
                Console.WriteLine($"Se ha desconectado el {nombreUsuario}@{ieClient.Address}");
                sw.Close();
                sr.Close();
                ns.Close();
                sclient.Close();
            }
        }
    }
}
