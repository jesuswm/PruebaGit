using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Tema2
{
    public abstract class Persona
    {
        public String   apellido; //Comno propiedad
        private String dni;
        private int edad;
        public String Nombre { set; get; }
        //{
        //    set
        //    {
        //        nombre = value;
        //    }
        //    get
        //    {
        //        return nombre;
        //    }
        //}
        public String Apellido
        {
            set
            {
                apellido = value;
            }
            get
            {
                return apellido;
            }
        }
        public Persona(String nombre,String apellido,String dni,int edad)
        {
            this.Nombre = nombre;
            this.apellido = apellido;
            Dni = dni;
            Edad = edad;
        }
        public Persona()
            : this("", "", "", 0)
        {
        }
        public int Edad{
            set
            {
                if (value>0)
                {
                    edad = value;
                }
                else
                {
                    edad = 0;
                }
            }
            get
            {
                return edad;
            }
        }
        public String Dni
        {
            set
            {
                    dni = value;
            }
            get
            {
                double a = Convert.ToDouble(dni);
                int resto = Convert.ToInt32(a % 23);
                String letras = "TRWAGMYFPDXBNJZSQVHLCKE";
                return dni+letras[resto]; //No devuelves letra
            }
        }
        public virtual void Mostrar()
        {
            Console.WriteLine("Nombre {0} \nApellido {1} \nEdad:{2} \nDNI:{3}",nombre,apellido,Edad,Dni);
        }
        public virtual void insertar()
        {
            Console.WriteLine("Introduce el nombre");
            this.nombre = Console.ReadLine();
            Console.WriteLine("Introduce el apellido");
            this.apellido = Console.ReadLine();
            Console.WriteLine("Introduce el dni");
            Dni = Console.ReadLine();
            Console.WriteLine("Introduce la edad");
            Edad = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void pedirDatos()
        {
            Console.WriteLine("Introduce el Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduce el Apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Introduce el Edad");
            Edad=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el DNI");
            Dni = Console.ReadLine();
        }
        public abstract double hacienda(double ganaEmp);
    }
}
