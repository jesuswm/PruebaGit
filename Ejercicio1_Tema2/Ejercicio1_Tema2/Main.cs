using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Tema2
{
    class main
    {
        static void obtenerGanacia(IPastaGansa a)
        {
            Console.WriteLine("Introduce la ganancia de la empresa");
            double ganacia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ganancias:" + a.ganarPasta(ganacia));
            Console.WriteLine("Hacienda: " + ((Persona)a).hacienda(ganacia));
        }
        static void Main(string[] args)
        {
            bool salir = false;
            Empleado emple=new Empleado("Paco","ger","39468908", 11, 10000, "986254581");
            Directivo dir = new Directivo("Alo", "per", "39468908", 22, "Sitio",5);
            EmpleadoEspecial emplees = new EmpleadoEspecial("Franks", "awd", "39468908", 33, 10000, "986254581","0.5%");
            do
            {
                Console.WriteLine("1.-Visualizar los datos del Directivo");
                Console.WriteLine("2.-Visualizar los datos del Empleado");
                Console.WriteLine("3.-Visualizar los datos del EmpleadoEspecial");
                Console.WriteLine("4.-Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("---------------------");
                //emple.Mostrar(1);
                //Console.WriteLine("---------------------");
                switch (opcion){
                    case 1:
                        dir.Mostrar();
                        obtenerGanacia(dir);
                        
                        break;
                    case 2:
                        emple.Mostrar();
                        Console.WriteLine("Hacienda: " + emple.hacienda(0));
                        break;
                    case 3:
                        emplees.Mostrar();
                        obtenerGanacia(emplees);
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("a");
                        break;
                }
            } while (!salir);
        }
    }
}
