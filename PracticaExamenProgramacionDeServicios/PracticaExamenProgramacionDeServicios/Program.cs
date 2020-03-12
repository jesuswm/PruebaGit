using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
namespace PracticaExamenProgramacionDeServicios
{
    public class Program
    {
        static readonly object l = new object();
        int posTortuga = 0;
        int posLiebre = 0;
        Boolean finCarrera = false;
        String ganador="";
        void dormir()
        {
            Random a = new Random();
            Thread.Sleep(a.Next(1, 4) * 1000);
            lock (l)
            {
                Monitor.Pulse(l);
            }
        }
        public void correTorruga()
        {
            lock (l)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write(String.Format("{0,10}", "Tortuga"));
            }
            int posvisual = 11;
            while (!finCarrera)
            {
                lock (l)
                {
                    if (!finCarrera)
                    {
                        if (posLiebre==posTortuga)
                        {
                            lock (l)
                            {
                                Random generador = new Random();
                                if (generador.Next(1, 11) <= 5)
                                {
                                    Monitor.Pulse(l);
                                }
                            }
                        }
                        Console.SetCursorPosition(posvisual, 0);
                        Console.Write(".");
                        posTortuga = posTortuga + 1;
                        posvisual = posvisual + 1;
                        Console.SetCursorPosition(0, 3);
                        Console.Write("La tortuga ha dado {0} pasos", posTortuga);
                    }
                    if (posTortuga >= 25)
                    {
                        finCarrera = true;
                        ganador = "Tortuga";
                        Monitor.Pulse(l);
                    }
                }
                if (!finCarrera)
                {
                    Thread.Sleep(300);
                }
            }
        }
        public void correrLiebre()
        {

            lock (l)
            {
                Console.SetCursorPosition(0, 1);
                Console.Write(String.Format("{0,10}", "Liebre"));
            }
            int posvisual = 11;
            while (!finCarrera)
            {
                lock (l)
                {
                    if (!finCarrera)
                    {
                        Console.SetCursorPosition(posvisual, 1);
                        Console.Write(string.Format("{0,6}", "."));
                        posLiebre = posLiebre + 6;
                        posvisual = posvisual + 6;
                        Console.SetCursorPosition(0, 4);
                        Console.Write("La Liebre ha dado {0} pasos", posLiebre);
                        Random generador = new Random();
                        if (generador.Next(1, 11) <= 6)
                        {
                            Console.SetCursorPosition(28, 4);
                            Console.Write(String.Format("{0,-10}", "Dormido"));
                            new Thread(dormir).Start();
                            lock (l)
                            {
                                Monitor.Wait(l);
                            }
                        }
                        Console.SetCursorPosition(28, 4);
                        Console.Write(String.Format("{0,-10}", "Despierto"));
                    }
                    if (posLiebre >= 25)
                    {
                        finCarrera = true;
                        ganador = "Liebre";
                    }
                }
                if (!finCarrera)
                {
                    Thread.Sleep(200);
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader leer = new StreamReader(Environment.GetEnvironmentVariable("USERPROFILE") + "\\guardado.txt"))
                {
                    Console.WriteLine("Lista de ganadores");
                    Console.WriteLine(leer.ReadToEnd());
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Aun no existe el archivo");
            }
            Console.ReadKey();
            Console.Clear();
            Program ej = new Program();
            Thread a = new Thread(ej.correTorruga);
            Thread b = new Thread(ej.correrLiebre);
            a.Start();
            b.Start();
            b.Join();
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("El ganador es "+ej.ganador);
            using (StreamWriter escribir = new StreamWriter(Environment.GetEnvironmentVariable("USERPROFILE") + "\\guardado.txt",true))
            {
                escribir.WriteLine(ej.ganador);   
            }
            Console.ReadKey();
        }
    }
}
