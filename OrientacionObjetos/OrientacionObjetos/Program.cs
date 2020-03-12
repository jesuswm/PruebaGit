using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacionObjetos
{
    class Perro
    {
        public string raza;
        public string nombre;

        private int edad;
    //    // Nota: aunque lo veas así en este ejemplo,
    //    // en C# NO haremos el set y el get de esta forma.
    //    // La correcta se explica en un apartado posterior.
    //    public int getEdad()
    //    {
    //        return edad;
    //    }


    //    public void setEdad(int edad)
    //{
    //    this.edad = edad;
    //}
    public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

    public Perro()
    {
        this.Edad=0;
        this.raza = "";
        this.nombre = "";
    }
    ~Perro()
        {
            Console.WriteLine("Finalizado el perro");
        }
    }
class Program
{
    static void Main()
    {
        Perro objPerro = new Perro();
        objPerro.raza = "Mastín";
        objPerro.nombre = "Laika";
        objPerro.Edad=5;
        Console.WriteLine(objPerro.Edad);
        Console.ReadLine();
    }
}
}
