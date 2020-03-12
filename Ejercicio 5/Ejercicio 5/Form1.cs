using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public DialogResult mostrarPestaña(String texto,String titulo, MessageBoxButtons botones ,MessageBoxIcon icono)
        {
             DialogResult result = MessageBox.Show
                (texto,titulo,botones,icono);
            return result;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(mostrarPestaña("Deséa cambiar el Título de la ventana por" + textBox1.Text, "¿Cambiar Título?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Text = textBox1.Text;
            }
        }
    }
}
