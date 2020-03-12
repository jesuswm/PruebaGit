using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PruebaServicio2
{
    class Echo
    {
        private int puerto;

        // Para realizar la pausa del servicio
        public bool pausa;
        public bool salir = false;
        public EventWaitHandle espera = new AutoResetEvent(false);
        //Constructor
        public Echo(int puerto)
        {
            this.puerto = puerto;
            pausa = false;
        }
        // Método principal. Es el que lanza realmente el servicio
        public void inicioServidorEcho()
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, puerto);
            Socket s = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            s.Bind(ie);
            s.Listen(10);
            escribeEvento(String.Format("Servidor a la espera en {0}", ie.Port));
            while (!salir)
            {
                //La pausa sólo impide nuevas conexiones, no afecta a las existentes
                //Es el único cambio respecto al antiguo Main
                //Se podría añadir un mensaje de Servidor pausado
                Socket cliente = s.Accept();
                if (pausa)
                {
                    cliente.Shutdown(SocketShutdown.Both);
                    espera.WaitOne();
                }
                else
                {
                    Thread hilo = new Thread(hiloCliente);
                    hilo.IsBackground = true;
                    hilo.Start(cliente);
                }
            }
        }
        //Este método no cambia en nada respecto a la versión anterior
        private void hiloCliente(object socket)
        {
            escribeEvento("Inicio hilo cliente");
            string mensaje;
            Socket cliente = (Socket)socket;
            IPEndPoint ieCliente = (IPEndPoint)cliente.RemoteEndPoint;
            escribeEvento(String.Format("Conectado con el cliente {0} en el puerto {1}",
            ieCliente.Address, ieCliente.Port));
            NetworkStream ns = new NetworkStream(cliente);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            string welcome = "Bienvenido al servidor";
            sw.WriteLine(welcome);
            sw.Flush();
            while (true)
            {
                try
                {
                    mensaje = sr.ReadLine();
                    sw.WriteLine(mensaje);
                    sw.Flush();
                }
                catch (IOException)
                {
                    //Salta al acceder al socket
                    //y no estar permitido
                    break;
                }
            }
            escribeEvento(String.Format("Conexión finalizada con {0}:{1}",
            ieCliente.Address, ieCliente.Port));
            sw.Close();
            sr.Close();
            ns.Close();
            cliente.Close();
        }
        public void escribeEvento(string mensaje)
        {
            string nombre = "Servidor de Echo"; //Nombre del servico
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
        
