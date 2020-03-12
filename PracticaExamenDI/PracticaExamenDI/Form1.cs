using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaExamenDI
{

    public partial class Form1 : Form
    {
 
        struct Dato
        {
            public String nombre, descripcion, nota, tipo;
            public Urgencia urg;
        }
        List<Dato> datos = new List<Dato>();
        enum Urgencia { Ya, Hoy, Mañana };
        Form2 secundario=new Form2();
        int[] pin = { 1111, 2222, 3333, 4444, 5555 };
        Boolean acerte = false;
        public Form1()
        {
            InitializeComponent();
            while (!acerte)
            {
                if (secundario.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (pin.Contains(Convert.ToInt32(secundario.getTpin())))
                        {
                            acerte=true;
                        }
                    }
                    catch (System.FormatException)
                    {
                        secundario.setLblError("Nose ha introducido un valor numerico");
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            if (!secundario.getcheck())
            {
                urgencia.Visible = false;
                tipo.Visible = false;
            }
            this.Visible = true;
    }

        private void Txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = (Color)((TextBox)sender).Tag;
        }

        private void Txt_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = default;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Desea Salir del programa", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                e.Cancel = true;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Salir del programa", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Environment.Exit(0);
            }
        }

        private void BtnAlmacenar_Click(object sender, EventArgs e)
        {
            datos.Add(new Dato());
        }
    }
}
