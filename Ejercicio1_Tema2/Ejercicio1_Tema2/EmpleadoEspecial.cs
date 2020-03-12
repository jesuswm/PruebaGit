using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Tema2
{
    class EmpleadoEspecial : Empleado, IPastaGansa
    {
        String beneficios;
        public EmpleadoEspecial()
            :base()
        {
            this.beneficios = "0.5%";
        }
        public EmpleadoEspecial(String nombre, String apellido, String dni, int edad, int salario, String telefono,String beneficios)
            : base(nombre, apellido, dni, edad, salario, telefono)
        {
            this.beneficios = beneficios;
        }


        public double ganarPasta(double a)
        {
            return a* Convert.ToDouble(this.beneficios.Replace("%", "")) / 100;
        }
        public override double hacienda(double ganaEmp)
        {
            return base.hacienda(ganaEmp) + (0.1 * ganarPasta(ganaEmp));
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Beneficio"+beneficios);
        }
    }
}
