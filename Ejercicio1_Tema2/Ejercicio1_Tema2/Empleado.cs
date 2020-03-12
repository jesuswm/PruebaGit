using System;
namespace Ejercicio1_Tema2
{
    public class Empleado : Persona
    {
        private double salario;
        private String irpf;
        private String telefono; 
        public Empleado(String nombre, String apellido, String dni, int edad, int salario, String telefono)
            : base(nombre, apellido, dni, edad)
        {
            Salario = salario;
            this.telefono = telefono;
        }
        public Empleado()
            : this(null, null, null, 0, 0, null) 
        {
        }
        public String Telefono
        {
            //set??
            set
            {
                telefono = value;
            }
            get
            {
                return "+34" + telefono;
            }
        }
        public double Salario
        {
            set
            {
                salario = value;
                switch (salario)
                {
                    case double a when salario < 600:
                        irpf = "7%";
                        break;
                    case double a when salario > 3000:
                        irpf = "20%";
                        break;
                    default:
                        irpf = "15%";
                        break;
                }
            }
            get
            {
                return salario;
            }
        }
        public override void    Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Salario: {0} \nIrpf: {1} \nTelefono:{2}", Salario, irpf, telefono);
        }
        public void Mostrar(int a) //No muestra nada
        {
            switch(a){
                case 0:
                    Console.WriteLine("Nombre: {0}",base.Nombre);
                    break;
                case 1:
                    Console.WriteLine("Apellido: {0}", base.Apellido);
                    break;
                case 2:
                    Console.WriteLine("Edad: {0}", base.Edad);
                    break;
                case 3:
                    Console.WriteLine("Dni: {0}", base.Dni);
                    break;
                case 4:
                    Console.WriteLine("Salario: {0}", Salario);
                    break;
                case 5:
                    Console.WriteLine("Irpf: {0}", irpf);
                    break;
                case 6:
                    Console.WriteLine("Teléfono: +34 {0}", telefono);
                    break;
            }
        }
        public override double hacienda(double ganaEmp)
        {
            return ((Convert.ToDouble(irpf.Replace('%', ' '))/100) * (Salario / 100)) ;
        }
    }
}
