using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Tema2
{
    class Directivo : Persona, IPastaGansa
    {
        String nDepart, beneficios;
        private int empleados;
        public int Empleados
        {
            set
            {
                empleados = value;
                switch (empleados)
                {
                    case int a when empleados <= 10:
                        beneficios = "2%";
                        break;
                    case int a when (11 >= empleados) && (empleados <= 50):
                        beneficios = "3.5%";
                        break;
                    case int a when empleados > 50:
                        beneficios = "4%";
                        break;
                }
            }
            get
            {
                return empleados;
            }
        }
        public static Directivo operator --(Directivo d)
        {
            int a = Convert.ToInt32(d.beneficios.Replace("%", ""));
            if ((a - 1) > 0)
            {
                d.beneficios = Convert.ToString(a - 1) + "%";
            }
            return d;
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Departamento {0} \nEmpleados {1} \nBeneficios:{2}\n", nDepart, Empleados, beneficios);
        }
        public override void insertar()
        {
            base.insertar();
            Console.WriteLine("Introduce el numero de empleados");
            Empleados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el nombre de departamento");
            nDepart = Console.ReadLine();
        }
        public override double hacienda(double ganaEmp)
        {
            return ganarPasta(ganaEmp) * 0.30;
        }
        public double ganarPasta(double a)
        {
            if (a > 0)
            {
                double beneficios = Convert.ToInt32(this.beneficios.Replace("%", ""));
                return a * (beneficios / 100);
            }
            else
            {
                Directivo b = this;
                b--;
                return 0;
            }
        }
        public Directivo(String nombre, String apellido, String dni, int edad, String nDepart, int empleados)
            : base(nombre, apellido, dni, edad)
        {
            this.nDepart = nDepart;
            Empleados = empleados;
        }
    }
}
