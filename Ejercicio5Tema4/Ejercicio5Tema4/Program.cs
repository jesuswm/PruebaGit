using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio5Tema4
{
    public delegate void Funcion();
    class MyTimer
    {
        static readonly object l = new object();
        bool activado;
        int intervalo;
        Funcion funcion;
        public int Intervalo
        {
            get
            {
                return intervalo;
            }
            set
            {
                intervalo = value;
            }
        }
        public void stop()
        {
            lock (l)
            {
                activado = false;
            }
        }
        public void start()
        {
            lock (l)
            {
                activado = true;
                Monitor.Pulse(l);
            }

        }
        public MyTimer(int intervalo, Funcion funcion)
        {
            Intervalo = intervalo;
            this.funcion = funcion;
            activado = true;
            Thread a = new Thread(() =>
            {
                lock (l)
                {
                    Monitor.Wait(l);
                }
                while (true)
                {
                    lock (l)
                    {
                        if (activado)
                        {
                            funcion();
                        }
                        else
                        {
                            Monitor.Wait(l);
                        }
                    }
                    Thread.Sleep(intervalo);
                }
            }
            );
            a.IsBackground = true;
            a.Start();
        }
    }
    class Program
    {
        static int counter = 0;
        static void increment()
        {
            counter++;
            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            Funcion funcion = increment;
            MyTimer t = new MyTimer(1000, increment);
            string op = "";
            do
            {
                Console.WriteLine("Press any key to start.");
                Console.ReadKey();
                t.start();
                Console.WriteLine("Press any key to stop.");
                Console.ReadKey();
                t.stop();
                Console.WriteLine("Press 1 to restart or Enter to end.");
                op = Console.ReadLine();
            } while (op == "1");
        }
    }
}
