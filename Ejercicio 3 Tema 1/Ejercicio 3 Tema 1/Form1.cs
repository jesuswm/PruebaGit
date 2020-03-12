//#define PRUEBA
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3_Tema_1
{
    public partial class Form1 : Form
    {
        int creditos = 50;
        public Form1()
        {
            InitializeComponent();
            lcredito.Text= "Creditos" + creditos + "€";
        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            if (creditos >= 2)
            {
                Random generador = new Random();
                creditos = creditos - 2;
                textBox1.Text = Convert.ToString(generador.Next(1, 7));
                textBox2.Text = Convert.ToString(generador.Next(1, 7));
                textBox3.Text = Convert.ToString(generador.Next(1, 7));
                if (textBox1.Text == textBox2.Text && textBox2.Text == textBox3.Text)
                {
                    premio.Text = "Hay premio 20€";
                    creditos = creditos + 20;
                }
                else { 
                    if ((textBox1.Text == textBox2.Text && textBox2.Text != textBox3.Text) || (textBox1.Text != textBox2.Text && textBox2.Text == textBox3.Text) || (textBox3.Text == textBox1.Text && textBox2.Text != textBox1.Text))
                    {
#if PRUEBA
                        creditos = creditos - 5;
                        premio.Text = "Hay perdida +5€";
#else
                        creditos = creditos + 5;
                        premio.Text = "Hay premio 5€";
                    #endif
                    }
                    else{
                        premio.Text = "no hay premio";
                    }
                }
                lcredito.Text = "Creditos" + creditos+ "€";
            }
        }

        private void Bcredito_Click(object sender, EventArgs e)
        {
            creditos = creditos + 10;
            lcredito.Text= "Creditos" + creditos + "€";
        }
    }
}
