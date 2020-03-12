using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio1Tema3
{
    class Program
    {
        static void pedirdatos(Hashtable datos)
        {
            bool valido=true;
            string ip;
            do
            {
                valido = true;
                Console.WriteLine("Introduce la IP del equipo");
                ip = Console.ReadLine();
                //ip.Split('.');
                if (ip.Split('.').Length == 4)
                {
                    foreach (String a in ip.Split('.'))
                    {
                        try
                        {
                            if (Convert.ToInt32(a) > 255 || Convert.ToInt32(a) < 0)
                            {
                                valido = false;
                            }
                        }
                        catch (System.FormatException error)
                        {
                            valido = false;
                            Console.WriteLine("La direccion ip no es valida");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("La direccion ip no es valida");
                    valido = false;
                }
            } while (!valido);
            int espacio=0;
            do
            {
                valido = true;
                Console.WriteLine("Introduce la RAM en GB");
                try
                {
                    espacio = Convert.ToInt32(Console.ReadLine());
                    if (espacio<0)
                    {
                        Console.WriteLine("la RAM no puede ser inferior o igual a 0");
                        valido = false;
                    }
                }catch(System.FormatException error)
                {
                    Console.WriteLine("Es necesario un valor numerico");
                    valido = false;
                }

            } while (!valido);
            if (!datos.ContainsKey(ip)) {
                datos.Add(ip, espacio);
            }
            else
            {
                Console.WriteLine("Ese equipo ya esta registrado");
            }
        }
        static void mostrartodos(Hashtable datos)
        {
            foreach(DictionaryEntry a in datos)
            {
                Console.WriteLine("Ip {0}: RAM {1}GB",a.Key,a.Value);
            }
        }
        static void Main(string[] args)
        {
            Hashtable datos = new Hashtable();
            Boolean salir = false;
            do
            {
                int selec;
                String ip;
                try { 
                    Console.WriteLine("1.-Añadir datos");
                    Console.WriteLine("2.-Mostrar todos los elementos");
                    Console.WriteLine("3.-Mostrar el valor de una ip determinada");
                    Console.WriteLine("4.-Salir");
                    selec = Convert.ToInt32(Console.ReadLine());
                    switch (selec)
                    {
                        case 1:
                            pedirdatos(datos);
                            break;
                        case 2:
                            mostrartodos(datos);
                            break;
                        case 3:
                            Console.WriteLine("Introde el ip del equipo del que quieres obtener la RAM");
                            ip = Console.ReadLine();
                            if(datos.ContainsKey(ip)){
                                Console.WriteLine("La RAM del equipo es de {0}GB",datos[ip]);
                            }
                            else
                            {
                                Console.WriteLine("Esa ip no se encuentra en el hasmap");
                            }
                            break;
                        case 4:
                            salir = true;
                            break;
                    }
                }catch (System.FormatException error)
                {
                    Console.WriteLine("Es necesario un valor numerico");
                }
            } while (!salir);
        }
    }
}
