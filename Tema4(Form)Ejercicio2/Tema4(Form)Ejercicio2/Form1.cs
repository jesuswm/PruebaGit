#define teclas
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Tema4_Form_Ejercicio2
{
    public partial class Form1 : Form
    {
        String primerTitulo;
        public Form1()
        {
            InitializeComponent();
            primerTitulo = Text;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
                Text = ("Eje X:" + e.Location.X + " Eje Y:" + e.Location.Y);
        }
        private void Buttons_MouseMove(object sender, MouseEventArgs e)
        {
            Text = ("Eje X:" +(((Button)sender).Location.X+ e.Location.X) + " Eje Y:" + (((Button)sender).Location.Y + e.Location.Y));
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Text = primerTitulo;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((Button)Derecha).BackColor = Color.Aquamarine;
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    ((Button)Izquierda).BackColor = Color.Coral;
                }
                else
                {
                    ((Button)Derecha).BackColor = Color.Aquamarine;
                    ((Button)Izquierda).BackColor = Color.Coral;
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((Button)Derecha).BackColor = new Button().BackColor;
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    ((Button)Izquierda).BackColor = new Button().BackColor;
                }
                else
                {
                    ((Button)Derecha).BackColor = new Button().BackColor;
                    ((Button)Izquierda).BackColor = new Button().BackColor;
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Escape)
            {
                Text = primerTitulo;
            }
            #if teclas
            else
            {
                Text = e.KeyCode.ToString();
            }
#else
            else{
                Text = Convert.ToInt32(e.KeyCode)+"";
            }
#endif
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
#if !teclas
            if (e.KeyChar == (char)Keys.Escape)
            {
                Text = primerTitulo;
            }
            else
            {
                Text = Convert.ToString(e.KeyChar);
            }
#endif
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Desa cerrar el programa?", "¿Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
