using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico1Servidores
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valido = false;
            bool encendido = true;
            int puerto = 1;
            Socket s = null;
            while (!valido)
            {
                try
                {
                    IPEndPoint ie = new IPEndPoint(IPAddress.Any, puerto); //cONTROL PUERTO OCUPADO
                    s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    s.Bind(ie);
                    s.Listen(10);
                    Console.WriteLine($"Port {puerto} free");
                    valido = true;
                }
                catch (System.Net.Sockets.SocketException) { puerto++; }
            }
            while (encendido)
            {
                Socket sClient = s.Accept();
                IPEndPoint ieClient = (IPEndPoint)sClient.RemoteEndPoint;
                Console.WriteLine("Client connected:{0} at port {1}", ieClient.Address, ieClient.Port);
                NetworkStream ns = new NetworkStream(sClient);
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);
                sw.WriteLine("Bienvenido");
                sw.Flush();
                String mensaje;
                mensaje = sr.ReadLine();
                if (mensaje != null)
                {
                    Console.WriteLine("{0} says: {1}", ieClient.Address, mensaje);
                    DateTime thisDay;
                    switch (mensaje)
                    {
                        case "HORA":
                            thisDay = DateTime.Now;
                            sw.WriteLine(thisDay.ToString("T"));
                            break;
                        case "FECHA":
                            thisDay = DateTime.Now;
                            sw.WriteLine(thisDay.ToString("d"));
                            break;
                        case "TODO":
                            thisDay = DateTime.Now;
                            sw.WriteLine(thisDay.ToString("G"));
                            break;
                        case "APAGAR":
                            encendido = false;
                            break;
                    }
                    Console.WriteLine("Client disconnected:{0} at port {1}", ieClient.Address, ieClient.Port);
                }
                sw.Close();
                sr.Close();
                ns.Close();
                sClient.Close();
            }
            s.Close();
        }
    }
}
