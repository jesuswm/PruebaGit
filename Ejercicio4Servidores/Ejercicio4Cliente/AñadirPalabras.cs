using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio4Cliente
{
    public partial class AñadirPalabras : Form
    {
        bool modoPalabras = true;
        public AñadirPalabras()
        {
            InitializeComponent();
        }

        private void RadioArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender).Name== "radioArchivo")
                {
                    modoPalabras = false;
                    tPalabras.Enabled = false;
                    bArchivo.Enabled = true;
                }
                else
                {
                    modoPalabras = true;
                    tPalabras.Enabled = true;
                    bArchivo.Enabled = false;
                }
            }
        }
        public string ResultadoFormulario()
        {
            if (modoPalabras)
            {
                return tPalabras.Text;
            }
            else
            {
                if (openFileDialog1.FileName != "openFileDialog1")
                {
                    String contenido = null;
                    try
                    {
                        StreamReader leer = new StreamReader(openFileDialog1.FileName);
                        contenido = leer.ReadToEnd();
                        leer.Close();
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Se ha producido un error al intentar leer el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return contenido;
                }
                else
                {
                    return null;
                }
            }
        }

        private void BArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
