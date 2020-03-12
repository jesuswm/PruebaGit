//#define FRASE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la primera frase");
            String frase1=Console.ReadLine();
            Console.WriteLine("Introduce la segunda frase");
            String frase2=Console.ReadLine();
            #if FRASE
                Console.WriteLine("\"{0}\" \\{1}\\",frase1,frase2);
            #else
                Console.WriteLine("{0}\t{1}\n{0}\n{1}",frase1,frase2);
            #endif
            Console.ReadKey();
        }
    }
}
