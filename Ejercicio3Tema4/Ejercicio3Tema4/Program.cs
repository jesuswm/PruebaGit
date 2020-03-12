using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio3Tema4
{
    class Program
    {
        static int objetivo = 100;
        static int numero = 0;
        static bool fin = false;
        static private object l = new object();
        static void add()
        {
            while (!fin)
            {
                lock (l)
                {
                    if (!fin)
                    {
                        // Console.SetCursorPosition(0, 0);
                        numero++;
                        Console.WriteLine("Thead1 {0,4}", numero);
                    }
                    if (numero == objetivo)
                    {
                        fin = true;
                    }
                }
            }

        }
        static void sub()
        {
            while (!fin)
            {
                lock (l)
                {
                    if (!fin)
                    {
                        //Console.SetCursorPosition(0, 0);
                        numero--;
                        Console.WriteLine("Thead2 {0,4}", numero);
                    }
                    if (numero == -objetivo)
                    {
                        fin = true;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Thread sumar = new Thread(add);
            Thread restar = new Thread(sub);
            sumar.Start();
            restar.Start();
            //new Thread(() =>
            //{
            //    while (!fin)
            //{
            //    lock (l)
            //    {
            //        if (!fin)
            //        {
            //            Console.SetCursorPosition(0, 0);
            //            numero++;
            //            Console.Write("Thead1 {0,4}", numero);
            //        }
            //        if (numero == objetivo)
            //        {
            //            fin = true;
            //        }
            //    }
            //}
            //    }
            //}).Start();
            //new Thread(() =>
            //{
            //    while (!fin)
            //{
            //    lock (l)
            //    {
            //        if (!fin)
            //        {
            //            Console.SetCursorPosition(0, 0);
            //            numero--;
            //            Console.Write("Thead2 {0,4}", numero);
            //        }
            //        if (numero == -objetivo)
            //        {
            //            fin = true;
            //        }
            //    }
            //}
            //}).Start();
            Console.ReadKey();
        }
    }
}
