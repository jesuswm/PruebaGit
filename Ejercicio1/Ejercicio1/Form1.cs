using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = Convert.ToDouble(textBox1.Text);
                double numero2 = Convert.ToDouble(textBox2.Text);
                label2.Text = "= " + (numero1 + numero2);
            }catch(System.FormatException error)
            {
                Console.WriteLine("No se han introducido valores validos");
                label2.Text = "= ?";
            }

        }
    }
}
