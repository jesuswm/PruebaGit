using System;
using System.Collections;
namespace Ejercicio2Tema3
{
    public class Ejercio2
    {
        static void Main(string[] args)
        {
            String[] nombres = new String[12];
            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = "Tipo" + i;
            }
            asignaturas asig = 0;
            int select;
            Boolean salir = false;
            Aula a = new Aula();
            a.Rellenar();
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.-Calcular la media de notas de toda la tabla.");
                Console.WriteLine("2.-Media de un alumno");
                Console.WriteLine("3.-Media de una asignatura");
                Console.WriteLine("4.-Visualizar notas de un alumno");
                Console.WriteLine("5.-Visualizar notas de una asignatura");
                Console.WriteLine("6.-Nota máxima y mínima de un alumno");
                Console.WriteLine("7.-Tabla solo de aprobados");
                Console.WriteLine("8.-Visualizar tabla completa");
                Console.WriteLine("9.-Salir");
                try
                {
                    select = Convert.ToInt32(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            Console.WriteLine("La media de la clase es {0:0.##}", a.CalcularMediasTotal());
                            break;
                        case 2:
                            Console.WriteLine("Introduce el numero de un alumno");
                            select = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("La media de {0} es {1:0.##}", nombres[select], a.CalcularMediaAl(select));
                            break;
                        case 3:
                            Console.WriteLine("Introduce el numero de la asignatura");
                            select = Convert.ToInt32(Console.ReadLine());
                            asig = (asignaturas)select;
                            Console.WriteLine("La media en {0} es de {1:0.##}", asig, a.CalcularMediaAsig(select));
                            break;
                        case 4:
                            Console.WriteLine("Introduce el numero de un alumno");
                            select = Convert.ToInt32(Console.ReadLine());
                            Console.Write(a.VisualizarAluc(select, nombres));
                            break;
                        case 5:
                            Console.WriteLine("Introduce el numero de la asignatura");
                            select = Convert.ToInt32(Console.ReadLine());
                            asig = (asignaturas)select;
                            Console.Write(a.VisualizarAsig(select, asig, nombres));
                            break;
                        case 6:
                            Console.WriteLine("Introduce el numero del alumno");
                            select = Convert.ToInt32(Console.ReadLine());
                            int min = 0;
                            asignaturas asigmaxi = 0;
                            asignaturas asigmini = 0;
                            int max = a.NotaMaxMinAl(select, ref min, ref asigmaxi, ref asigmini);
                            Console.WriteLine("La nota maxima del alumno es un {0} en {2} y la minima es {1} en {3}", max, min, asigmaxi, asigmini);
                            break;
                        case 7:
                            ArrayList aprobados = a.MostrarAprobadas(nombres);

                            if (aprobados.Count != 0)
                            {
                                for (int i = 0; i < aprobados.Count; i = i + 5)
                                {
                                    if (i + 4 < aprobados.Count)
                                    {
                                          Console.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}",aprobados[i],aprobados[i + 1],aprobados[i + 2],aprobados[i + 3],aprobados[i + 4]);
                                    }
                                }
                            }
                            break;
                        case 8:
                            Console.WriteLine(a.MostrarTodas(nombres));
                            break;
                        case 9:
                            salir = true;
                            break;
                    }
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("No se ha introducido un valor numerico se regresara al menu inicial");
                }
                catch (System.IndexOutOfRangeException e)
                {
                    Console.WriteLine("No existe una asignatura o alumno con ese numero");
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine("El valor introducido debe de estar entre -2.147.483.648 y 2.147.483.647");
                }
            } while (!salir);
        }
    }
}

