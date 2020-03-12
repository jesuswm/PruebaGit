using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Form_Ejercicio6
{
    public partial class Form2 : Form
    {
        int intentos=3;
        String pin = "1111";
        public Form2()
        {
            InitializeComponent();
        }
        public void actualizarIntentos()
        {
            label2.Text = "Nº de intentos " + intentos;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                if (textBox1.Text==pin)
                {
                    this.Visible = false;
                }
                else
                {
                    intentos--;
                    if (intentos == 0)
                    {
                        System.Windows.Forms.Application.ExitThread();
                    }
                    actualizarIntentos();
                }
            }
        }
    }
}
