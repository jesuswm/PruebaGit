using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Tema3
{
    class Erroroperator : Exception
    {
        public Erroroperator() : base("Operador no valido")
        {
        }
    }
    class Program
    {
        public float operacion(char operacion ,params int[] parametros)
        {
            float resultado=-1;
            if (operacion=='+' || operacion == '*')
            {
                if (parametros.Length!=0) {
                    resultado = parametros[0];
                    for (int i = 1; i < parametros.Length; i++)
                    {
                        if (operacion == '+')
                        {
                            resultado = resultado + parametros[i];
                        }
                        else
                        {
                            resultado = resultado * parametros[i];
                        }
                        
                    }
                }
            }
            else
            {
                throw new Ejercicio4Tema3.Erroroperator();
                //Console.WriteLine("Tipo de operacion no valida solamente se consideran validos + y *");
            }
            return resultado;
        }
        static void Main(string[] args)
        {
            if (args.Length==0) {
                try
                {
                    float a = new Program().operacion('*', 5, 5, 10, 8);
                    Console.WriteLine(a);
                    Console.ReadLine();
                }
                catch (Erroroperator error)
                {
                    Console.WriteLine(error.Message);
                    Console.ReadLine();
                }
            }
            else
            {
                if (args.Length>=2) {
                    try
                    {
                        float resultado = float.Parse(args[1]);
                        switch (args[0])
                        {
                            case "+":
                                for (int i = 2; i < args.Length; i++)
                                {
                                    resultado = resultado + float.Parse(args[i]);
                                }
                                Console.WriteLine(resultado);
                                break;
                            case "*":
                                for (int i = 2; i < args.Length; i++)
                                {
                                    resultado = resultado * float.Parse(args[i]);
                                }
                                Console.WriteLine(resultado);
                                break;
                            default:
                                Console.WriteLine("No se ha introducido una operacion valida como primer parametro (+ o *)");
                                break;
                        }
                    }
                    catch (IndexOutOfRangeException error)
                    {
                        Console.WriteLine("Uno de los parametros enviados en el operando no es un numero");
                    }
                }
                else
                {
                    Console.WriteLine("No se han introducido valores despues del operando");
                }
            }
        }
    }
}
