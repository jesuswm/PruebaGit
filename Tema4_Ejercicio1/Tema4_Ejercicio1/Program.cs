using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4_Ejercicio1
{
    public delegate void MyDelegate();
    class Program
    {
        static void f1()
        {
            Console.WriteLine("A");
        }
        static void f2()
        {
            Console.WriteLine("B");
        }
        static void f3()
        {
            Console.WriteLine("C");
        }
        static void MenuGenerator(String[] opciones, MyDelegate[] op)
        {
            if (opciones.Length == op.Length)
            {
                bool salir = false;
                int select;
                do
                {
                    try
                    {
                        for (int i = 0; i < opciones.Length; i++)
                        {
                            Console.WriteLine("{0}.-{1}", i + 1, opciones[i]);
                        }
                        Console.WriteLine("{0}.-Salir", opciones.Length + 1);
                        select = Convert.ToInt32(Console.ReadLine());
                        if (select > 0 && select <= opciones.Length + 1)
                        {
                            if (select == opciones.Length + 1)
                            {
                                salir = true;
                            }
                            else
                            {
                                op[select - 1]();
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("No se ha introducido un numero entero");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Introduce un valor De -2.147.483.648 a 2.147.483.647");
                    }
                } while (!salir);
            }
            else
            {
                Console.WriteLine("No se ha podido generar un menu no existen el mismo numero de funciones que opcciones");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            MyDelegate[] a = { f1, f2, f3, f2 };
            String[] opciones = { "op1", "op2", "op3", "op4" };
            MenuGenerator(opciones, a);
        }
    }
}
