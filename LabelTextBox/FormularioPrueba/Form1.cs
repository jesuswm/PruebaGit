using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LabelTextBox1_CambiaPosicion(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion == LabelTextBox.ePosicion.DERECHA)
            {
                this.Text = "Izquierda";
            }
            else
            {
                this.Text = "Derecha";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion==LabelTextBox.ePosicion.DERECHA)
            {
                labelTextBox1.Posicion = LabelTextBox.ePosicion.IZQUIERDA;
                
            }
            else
            {
                labelTextBox1.Posicion = LabelTextBox.ePosicion.DERECHA;  
            }
        }

        private void LabelTextBox1_CambiarSeparacion(object sender, EventArgs e)
        {
            //MessageBox.Show("Se aumento la separacion");
            System.Diagnostics.Debug.WriteLine("Separación +5");
        }

        private void LabelTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("KeyDow");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            labelTextBox1.Separacion = labelTextBox1.Separacion + 5;
        }

        private void LabelTextBox1_TextBoxChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Cambio el texto");
        }
    }
}
