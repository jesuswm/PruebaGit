using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace PracticaExamenServicio
{
    class ServidorArchivos
    {
        private readonly object l=new object(); 
        Socket SocketServer;
        public string leeArchivo(String archivo,int nlineas)
        {
            string contenido = "";
            lock (l)
            {
                StreamReader sr = new StreamReader(System.Environment.GetEnvironmentVariable("programdata") + "//" + archivo);
                for (int i = 0; i < nlineas; i++)
                {
                    contenido = contenido + sr.ReadLine();
                }
                sr.Close();
            }
            return contenido;
        }
        public ushort leePuerto()
        {
            ushort puerto = 31416;
            try
            {
                puerto = Convert.ToUInt16(leeArchivo("puerto.txt", 1));
            }
            catch (System.FormatException)
            {

            }
            catch (System.OverflowException)
            {

            }
            return puerto;
        }
        public void guardaPuerto(ushort numero)
        {
            lock (l)
            {
                StreamWriter sw = new StreamWriter(System.Environment.GetEnvironmentVariable("programdata") + "//puerto.txt");
                sw.WriteLine(numero);
                sw.Close();
            }
        }

        public string listaArchivos()
        {
            string lista="";
            DirectoryInfo directory = new DirectoryInfo(System.Environment.GetEnvironmentVariable("programdata"));
            foreach (FileInfo file in directory.GetFiles())
            {
                if (file.Extension ==".txt")
                {
                    lista = lista + file.Name+"\n\r";
                }
            }
            return lista;
        }
        public void iniciaServidorArchivos()
        {
            bool valido=false;
            bool salir=false;
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, leePuerto());
                SocketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                SocketServer.Bind(endPoint);
                Console.WriteLine("Servidor establecido en el puerto" + endPoint.Port);
                valido = true;
            }
            catch (SocketException)
            {
                Console.WriteLine("No se ha podido conetar al pueto");
            }
            if (valido)
            {
                while (!salir)
                {
                    try
                    {
                        SocketServer.Listen(10);
                        new Thread(hiloCliente).Start(SocketServer.Accept());
                    }
                    catch (System.Net.Sockets.SocketException)
                    {
                        salir = true;
                    }
                }
            }
            Console.WriteLine("Cerrando el servidor");
        }
        public void hiloCliente(object sock){
            NetworkStream ns = new NetworkStream((Socket)sock);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            bool salir = false;
            sw.WriteLine("Conexion establecida");
            sw.Flush();
            while (!salir)
            {
                String msg = sr.ReadLine();
                if (msg != null)
                {
                    try
                    {
                        switch (msg)
                        {
                            case string a when a.Substring(0, 3) == "GET":
                                string[] parametros = a.Remove(0, 3).Split(',');
                                int lineas;
                                if (parametros.Length == 2)
                                {
                                    sw.Write(leeArchivo(parametros[0].Trim(), Convert.ToInt32(parametros[1])));
                                    sw.Flush();
                                }
                                break;
                            case string a when a.Substring(0, 4) == "PORT":
                                try
                                {
                                    ushort p = Convert.ToUInt16(a.Remove(0, 4));
                                    guardaPuerto(p);
                                    sw.WriteLine("Puerto cambiado " + p);
                                    sw.Flush();
                                }
                                catch (System.FormatException)
                                {
                                    sw.WriteLine("valor no valido");
                                    sw.Flush();
                                }
                                catch (System.OverflowException)
                                {
                                    sw.WriteLine("valor no valido");
                                    sw.Flush();
                                }

                                break;
                            case string a when a.Substring(0, 4) == "LIST":
                                sw.Write(listaArchivos());
                                sw.Flush();
                                break;
                            case string a when a.Substring(0, 4) == "HALT":
                                sw.WriteLine("HALT");
                                lock (l)
                                {
                                    SocketServer.Close();
                                }
                                salir = true;
                                sw.Flush();
                                break;
                            case string a when a.Substring(0, 5) == "CLOSE":
                                sw.WriteLine("CLOSE");
                                sw.Flush();
                                salir = true;
                                break;
                        }
                    }
                    catch (System.ArgumentOutOfRangeException) { }
                }
                else
                {
                    salir = true;
                }
            }
            sw.Close();
            sr.Close();
            ns.Close();
            ((Socket)sock).Close();
        }

        static void Main(string[] args)
        {
            ServidorArchivos archivos = new ServidorArchivos();
            archivos.guardaPuerto(1);
            //System.Diagnostics.Debug.WriteLine(archivos.listaArchivos());
            //Console.ReadLine();
            archivos.iniciaServidorArchivos();
        }
    }
}
