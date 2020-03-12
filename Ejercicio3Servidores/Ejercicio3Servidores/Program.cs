using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Ejercicio3Servidores
{
    class Program
    {
        static readonly object l = new object();
        static readonly object tiempo = new object();
        static int puerto = 1;
        static int conectados = 0;
        static int esperaPartida = 5;
        static List<StreamWriter> writers = new List<StreamWriter>();
        static List<int> numeros = new List<int>();
        static Random generador = new Random();
        static bool suficientesJugadores = false;
        static bool apagar = false;
        static void Main(string[] args)
        {
            bool puertoLibre = false;
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, puerto);
            Socket socketserver = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            while (puertoLibre)
            {
                try
                {
                    socketserver.Bind(iPEndPoint);
                    socketserver.Listen(4);
                    puertoLibre = true;
                    Console.WriteLine($"Puerto valido: {puerto}");
                }
                catch (System.Net.Sockets.SocketException)
                {
                    puerto++;
                    puertoLibre = false;
                }

            }
            socketserver.Bind(iPEndPoint);
            socketserver.Listen(4);
            new Thread(partida).Start();
            while (true)
            {
                Socket cliente = socketserver.Accept();
                new Thread(hiloCliente).Start(cliente);
                lock (l)
                {
                    conectados++;
                }
            }
        }
        public static void timer()
        {
            DateTime inicio = DateTime.Now;
            int segundos = -1;
            while (DateTime.Now < inicio.AddSeconds(esperaPartida))
            {
                if (segundos != (inicio.AddSeconds(esperaPartida) - DateTime.Now).Seconds)
                {
                    segundos = (inicio.AddSeconds(esperaPartida) - DateTime.Now).Seconds;
                    lock (l)
                    {
                        foreach (StreamWriter writer in writers)
                        {
                            writer.WriteLine($"El juego comienza en {segundos}s");
                            writer.Flush();
                        }
                    }
                }

            }
            lock (tiempo)
            {
                Monitor.Pulse(tiempo);
            }
        }
        public static void partida()
        {
            while (!apagar)
            {
                Thread.Sleep(1500);
                if (!suficientesJugadores)
                {
                    lock (l)
                    {
                        if (conectados >= 2)
                        {
                            suficientesJugadores = true;
                        }
                        else
                        {
                            foreach (StreamWriter writer in writers)
                            {
                                writer.WriteLine($"No hay suficientes jugadores (jugadores conectados: {conectados} jugadores necesarios: 2)");
                                writer.Flush();
                            }
                        }
                    }
                }
                else
                {
                    lock (l)
                    {
                        foreach (StreamWriter writer in writers)
                        {
                            writer.WriteLine($"hay suficientes jugadores (jugadores conectados: {conectados})");
                            writer.Flush();
                        }
                    }
                    lock (tiempo)
                    {

                        new Thread(timer).Start();
                        Monitor.Wait(tiempo);
                    }
                    lock (l)
                    {
                        int ganador = 0;
                        for (int i = 0; i < writers.Count; i++)
                        {
                            numeros.Add(generador.Next(1, 21));
                        }
                        foreach (int mayor in numeros)
                        {
                            if (ganador <= mayor)
                            {
                                ganador = mayor;
                            }
                        }
                        for (int i = 0; i < writers.Count; i++)
                        {
                            if (numeros[i] == ganador)
                            {
                                writers[i].WriteLine($"Tu numero es el mayor {numeros[i]} Has Ganado!!!!!");
                                writers[i].Flush();
                            }
                            else
                            {
                                writers[i].WriteLine($"Tu numero es {numeros[i]} El ganador saco un {ganador}");
                                writers[i].Flush();
                            }
                        }
                        numeros = new List<int>();
                    }

                    suficientesJugadores = false;
                }
            }
        }
        public static void hiloCliente(Object socket)
        {
            if (socket is Socket)
            {
                bool salir = false;
                Socket sockCliente = (Socket)socket;
                NetworkStream ns = new NetworkStream(sockCliente);
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);
                sw.WriteLine("Bienvenido al Juego número más alto en red");
                sw.Flush();
                lock (l)
                {
                    writers.Add(sw);
                }
                while (!salir)
                {
                    if (sr.ReadLine() == null)
                    {
                        salir = true;
                    }
                }
                lock (l)
                {
                    conectados--;
                    writers.Remove(sw);
                }
                sw.Close();
                sr.Close();
                ns.Close();
                sockCliente.Close();
            }
        }
    }
}
