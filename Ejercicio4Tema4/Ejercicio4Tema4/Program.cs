using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio4Tema4
{
    class Program
    {
        static private object l = new object();
        static readonly object M = new object();
        static bool ganada=false;
        static char ganador = ' ';
        static int apuesta;
        public struct datos
        {
            int posiciony;
            int distancia;
            char identificador;
            public datos(int posiciony, int distancia,char identificador)
            {
                this.posiciony = posiciony;
                this.distancia = distancia;
                this.identificador = identificador;
            }
            public char Identificador
            {
                get
                {
                    return identificador;
                }
                set
                {
                    identificador = value;
                }
            }
            public int Posiciony
            {
                get
                {
                    return posiciony;
                }
                set
                {
                        posiciony = value;
                }
            }
            public int Distancia
            {
                get
                {
                    return distancia;
                }
                set
                {
                        distancia = value;
                }
            }
        }
        static void caballo(int posicionY, int distancia,char identificador)
        {
            int pos = 0;
            int avanzar;
            Random aleatorio= new Random();
            while (!ganada) {
                lock (l)
                {
                    if (!ganada)
                    {
                        avanzar = 1;// aleatorio.Next(1, 3);
                        Console.SetCursorPosition(pos, posicionY);
                        if (pos == 0)
                        {
                            Console.Write(identificador);
                            pos++;
                        }
                        else
                        {
                            for (int i = 0; i < avanzar; i++)
                            {
                                if (pos < distancia + 1)
                                {
                                    Console.Write("-");
                                    pos++;
                                }
                            }
                         
                        }

                        if (pos == distancia + 1  )
                        {
                            ganada = true;
                            ganador = identificador;
                            lock (M)
                            {
                                Monitor.Pulse(M);
                            }
                        }
                    }
                }
                Thread.Sleep(100);// avanzar * 100);
            }
        }
        static void caballo(object dato)
        {
            caballo(((datos)dato).Posiciony,((datos)dato).Distancia,((datos)dato).Identificador);
        }
        static void Main(string[] args)
        {
            Thread[] caballos = new Thread[5];
            datos datos = new datos();
            datos.Distancia = 10;
            bool salir = false;
            do {
                ganada = false;
                ganador = ' ';
                apuesta = 0;
                while (apuesta < 1 || apuesta > 5) {
                    try
                    {
                        Console.WriteLine("Por que caballo quieres apostar (valores entre 1 y 5)");
                        apuesta = Convert.ToInt32(Console.ReadLine());
                        if (apuesta < 1 || apuesta > 5)
                        {
                            Console.WriteLine("Introduzca un valor entre 1 y 5");
                        }
                    }
                    catch (FormatException error)
                    {
                        Console.WriteLine("No se ha introducido un numero");
                    }
                    catch (OverflowException error) {
                        Console.WriteLine("Introduzca un valor de -2.147.483.648 a 2.147.483.647");
                    }
                }
                Console.Clear();
                for (int i = 0; i < caballos.Length; i++)
                {
                    datos.Posiciony = i;
                    datos.Identificador = (char)(i + '1');
                    caballos[i] = new Thread(caballo);
                    caballos[i].Start(datos);
                }
                lock (M) {
                    Monitor.Wait(M);
                }
                lock (l)
                {
                    Console.SetCursorPosition(20, 20);
                    if (ganador == (char)('0' + apuesta))
                    {
                        Console.WriteLine("El ganador es {0} !!Has ganado!!", ganador);
                    }
                    else
                    {
                        Console.WriteLine("El ganador es {0} Has perdido", ganador);
                    }
                }
                Console.WriteLine("Para volver a jugar pulse R cualquier otro boton finalizara el programa");
                if (Console.ReadKey().Key!=ConsoleKey.R)
                {
                    salir = true;
                }
                else
                {
                    Console.Clear();
                }
            } while (!salir);
            }
            
    }
}
