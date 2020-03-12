using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Servicio1
{
    class Servidor
    {
        public Socket s;
        int puertoDefecto=1;
        public bool encendido = true;
        public void IniciarServer()
        {
            encendido = true;
            int puerto= puertoDefecto;
            try {
                StreamReader leer = new StreamReader(System.Environment.GetEnvironmentVariable("programdata") + "//puerto.txt");
                try
                {
                    puerto = Convert.ToInt32(leer.ReadToEnd().Trim());
                    if (puerto < 0 || puerto > 65536)
                    {
                        escribeEvento($"Valor del puerto del archivo invalido");
                        puerto = puertoDefecto;
                    }
                }
                catch (FormatException)
                {
                    escribeEvento($"Formato no valido en el archivo");
                    puerto = puertoDefecto;
                }
                leer.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                puerto = puertoDefecto;
                escribeEvento($"No se ha podido acceder al archivo se usara el puerto por defecto");
            }
            catch (System.OverflowException)
            {
                puerto = puertoDefecto;
                escribeEvento($"Valor del puerto del archivo invalido");
            }
            bool valido = false;
            s = null;
            //while (!valido)
            //{
            //    try
            //    {
            //        IPEndPoint ie = new IPEndPoint(IPAddress.Any, puerto); //cONTROL PUERTO OCUPADO
            //        s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //        s.Bind(ie);
            //        s.Listen(10);
            //        Console.WriteLine($"Port {puerto} free");
            //        valido = true;
            //    }
            //    catch (System.Net.Sockets.SocketException) { puerto++; }
            //}
            try
            {
                IPEndPoint ie = new IPEndPoint(IPAddress.Any, puerto); //cONTROL PUERTO OCUPADO
                s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                s.Bind(ie);
                s.Listen(10);
                escribeEvento($"Servidor establecido en el puerto {puerto}");
                valido = true;
            }
            catch (System.Net.Sockets.SocketException) {
                try
                {
                    IPEndPoint ie = new IPEndPoint(IPAddress.Any, puertoDefecto); //cONTROL PUERTO OCUPADO
                    s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    s.Bind(ie);
                    s.Listen(10);
                    escribeEvento($"Servidor establecido en el puerto {puertoDefecto}");
                    valido = true;
                }
                catch (System.Net.Sockets.SocketException)
                {
                    escribeEvento($"No se ha podido establecer el puerto");
                    valido = false;
                }
            }
            if (valido)
            {
                while (encendido)
                {
                    try {
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
                                    escribeEvento(thisDay.ToString("T"));
                                    break;
                                case "FECHA":
                                    thisDay = DateTime.Now;
                                    sw.WriteLine(thisDay.ToString("d"));
                                    escribeEvento(thisDay.ToString("d"));
                                    break;
                                case "TODO":
                                    thisDay = DateTime.Now;
                                    sw.WriteLine(thisDay.ToString("G"));
                                    escribeEvento(thisDay.ToString("G"));
                                    break;
                                case "APAGAR":
                                    encendido = false;
                                    s.Close();
                                    //ServiceController service;
                                    break;
                            }
                            Console.WriteLine("Client disconnected:{0} at port {1}", ieClient.Address, ieClient.Port);
                        }
                        sw.Close();
                        sr.Close();
                        ns.Close();
                        sClient.Close();
                    }
                    catch (System.Net.Sockets.SocketException)
                    {
                        escribeEvento($"Se va ha cerrar el servidor");
                    }
                }
            }
        }
        public void cerrarServidor()
        {
            encendido = false;
            s.Close();
        }
        public void escribeEvento(string mensaje)
        {
            string nombre = "UnServicioDeTiempo"; //Nombre del servico
            string logDestino = "Application"; // Donde aparece el evento (debe existir)
                                               //Se puede probar otro nombre y ver cómo da error
                                               //En el propio visor de eventos

            if (!EventLog.SourceExists(nombre))
            {
                EventLog.CreateEventSource(nombre, logDestino);
            }
            EventLog.WriteEntry(nombre, mensaje);
            //Existe más sobrecargas donde se indica Icono, ID, etc.
        }
    }
}
