using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Tema_1
{
    class Program
    {
        int caras=6;
        int numero;
        public char quiniela(Random generador)
        {
            char resultado=' ';
            int rand;
            rand = generador.Next(100);
            //Console.WriteLine(rand);
            switch (rand)
            {
                case int n when (rand <= 59):
                    //Console.WriteLine("estoy entre 0 y 59");
                    resultado = '1';
                    break;
                case int n when (rand > 59 && rand <= 84):
                    //Console.WriteLine("estoy entre 59 y 84");
                    resultado = 'X';
                    break;
                case int n when (rand > 84 && rand <= 99):
                    //Console.WriteLine("estoy entre 84 y 99");
                    resultado = '2';
                    break;
            }
            return resultado;
        }
        public int pedirInt()
        {
            int numero = 0;
            Boolean a=true;
            do
            {
                try
                {
                    numero = Convert.ToInt32(Console.ReadLine());
                    a = true;
                }
                catch (System.FormatException fallo)
                {
                    Console.WriteLine("No se ha introducido un numero entero");
                    a = false;
                }
            } while (a == false);
            return numero;
        }
        public void opcion1(int caras=6)
        {
            Boolean salir = true;
            do
            {
                int resultado = 0;
                int rand;
                do
                {
                    Console.WriteLine("Introduce un numero entero ente 1 y {0}", caras);
                    numero = pedirInt();
                }
                while (numero > caras);
                Random generador = new Random();
                for (int i = 0; i < 10; i++)
                {
                    rand = generador.Next(1,caras+1);
                    Console.WriteLine("La cpu tira y saca {0}", rand);
                    if (rand == numero)
                    {
                        resultado++;
                    }
                }
                Console.WriteLine("Has acertado {0} veces", resultado);
                Console.WriteLine("Para volver a jugar pulse 1 en para volver al menu principal pulse cualquier numero");
                if (pedirInt() == 1)
                {
                    salir = false;
                }
                else
                {
                    salir = true;
                }
            } while (!salir);
        }
        public void opcion2()
        {
            Boolean salir = true;
            Random generador = new Random();
            int rand;
            Boolean ganado;
            Console.WriteLine("Intenta adivinar el numero");
            do
            {
                rand = generador.Next(1,101);
                ganado = false;
                for (int i = 0; i < 5; i++) {
                    do
                    {
                        Console.WriteLine("--------------------Intento {0} -----------------------", i+1);
                        Console.WriteLine("Introduce un numero entero ente 1 y 100",i);
                        numero = pedirInt();
                    }
                    while (numero < 1 || numero > 100);
                    if (numero == rand)
                    {
                        Console.WriteLine("Has ganado");
                        ganado = true;
                        i = 5;
                    }
                    else
                    {
                        if (numero>rand)
                        {
                            Console.WriteLine("El numero que buscas es menor que {0}",numero);
                        }
                        else
                        {
                            Console.WriteLine("El numero que buscas es mayor que {0}", numero);
                        }
                    }
                }
                if (!ganado)
                {
                    Console.WriteLine("Has perdido el numero que buscabamos era {0}", rand);
                }
                Console.WriteLine("Para volver a jugar pulse 1 en para volver al menu principal pulse cualquier numero");
                if (pedirInt() == 1)
                {
                    salir = false;
                }
                else
                {
                    salir = true;
                }
            } while (!salir);
        }
        public void opcion3()
        {
            Boolean salir = true;
            Console.WriteLine("Quiniela");
            do {
                Random generador = new Random();
                for (int i = 0; i < 14; i++)
                {
                    Console.WriteLine(quiniela(generador));
                }
                Console.WriteLine("Para volver a jugar pulse 1 en para volver al menu principal pulse cualquier numero");
                if (pedirInt() == 1)
                {
                    salir = false;
                }
                else
                {
                    salir = true;
                }
            } while (!salir);
        }
        static void Main(string[] args)
        {
            int respuesta;
            Program ejercicio =new Program();
            Boolean salir=true;
            Boolean todos = false;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.-Juego 1");
                Console.WriteLine("2.-Juego 2");
                Console.WriteLine("3.-Juego 3");
                Console.WriteLine("4.-Todos los juegos");
                Console.WriteLine("5.-Salir");
                respuesta = ejercicio.pedirInt();
                switch (respuesta)
                {
                    case 1:
                        ejercicio.opcion1();
                        if (todos)
                        {
                            goto case 2;
                        }
                        salir = false;
                        break;
                    case 2:
                        ejercicio.opcion2();
                        if (todos)
                        {
                            goto case 3;
                        }
                        salir = false;
                        break;
                    case 3:
                        ejercicio.opcion3();
                        todos = false;
                        salir = false;
                        break;
                    case 4:
                        salir = false;
                        todos = true;
                        goto case 1;
                        break;
                    case 5:
                        salir=true;
                        break;
                }
            } while (!salir);
        }
    }
}
