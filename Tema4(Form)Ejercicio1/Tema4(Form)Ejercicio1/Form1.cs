using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tema4_Form_Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cambiarColor()
        {
            int r, g, b;
            try
            {
                r = Convert.ToInt32(tbr.Text);
                g = Convert.ToInt32(tbg.Text);
                b = Convert.ToInt32(tbb.Text);
                this.BackColor = Color.FromArgb(r, g, b);
            }
            catch (FormatException)
            {
                MessageBox.Show("No se han introducido numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Los valores rgb deben encontrarse entre 0 y 255", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Valor numerico demasiado grande", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere cerrar el programa?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Seguro que quiere cerrar el programa?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel=true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            cambiarColor();
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            try
            {
                // C:\Users\Jesus\Downloads\Campana.jpg
                Image a = Image.FromFile(tpath.Text);
                lImagen.Image = a;
        }
            catch (FileNotFoundException)
            {
                lImagen.Image = null;
            }
            catch (ArgumentException)
            {
                lImagen.Image = null;
            }
}

        private void CambiarColorBoton(object sender, EventArgs e)
        {
            
            ((Button)sender).BackColor = Color.Aqua ;
        }

        private void RecuperarColorBoton(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = new Button().BackColor;
            
        }

        private void PulsarEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(((TextBox)sender).Name == tpath.Name))  // Mejor en eventos Enter de textboxes
            {
                this.AcceptButton = button2;
            }
            else
            {
                this.AcceptButton = Cargar;
            }
        }
    }
}
