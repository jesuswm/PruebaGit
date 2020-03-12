using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Form_Ejercicio4
{
    public partial class Form1 : Form
    {
        Hashtable hastable = new Hashtable();
        delegate void funciones();
        int min=0;
        int sec=0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void CheckedChanged(object sender, EventArgs e)
        {
            operacion.Text = (String)((RadioButton)sender).Tag;   
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hastable.Add("+", new funciones(() => { Resultado.Text = Convert.ToString(Convert.ToInt32(numero1.Text) + Convert.ToInt32(numero2.Text)); }));
            hastable.Add("-", new funciones(() => { Resultado.Text = Convert.ToString(Convert.ToInt32(numero1.Text) - Convert.ToInt32(numero2.Text)); }));
            hastable.Add("*", new funciones(() => { Resultado.Text = Convert.ToString(Convert.ToInt32(numero1.Text) * Convert.ToInt32(numero2.Text)); }));
            hastable.Add("/", new funciones(() => { Resultado.Text = Convert.ToString(Convert.ToInt32(numero1.Text) / Convert.ToInt32(numero2.Text)); }));
        }
        private void Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                ((funciones)hastable[operacion.Text])();
            }
            catch (System.FormatException)
            {
                Resultado.Text = "No son valores numericos";
            }
            catch (System.OverflowException)
            {
                Resultado.Text = "Numero demasiado grande en los campos";
            }
            catch (DivideByZeroException)
            {
                Resultado.Text = "No se puede dividir entre 0";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec==60)
            {
                sec = 0;
                min++;
            }
            this.Text = String.Format("{0,2:D2}:{1,2:D2}", min, sec);
        }
    }
}
