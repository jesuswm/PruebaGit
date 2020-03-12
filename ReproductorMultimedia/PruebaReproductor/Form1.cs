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

namespace PruebaReproductor
{
    public partial class Form1 : Form
    {
        private DirectoryInfo carpeta = null;
        private FileInfo[] files;
        int actual = -1;
        int segundos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            carpeta = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            if (carpeta != null)
            {
                try
                {
                    files = carpeta.GetFiles();
                    //Reproductor.setImage(null);
                    pictureBox1.Image=null;
                    actual = -1;
                }
                catch (System.IO.DirectoryNotFoundException) { carpeta = null; }
                catch (System.UnauthorizedAccessException) {
                    carpeta = null;
                    MessageBox.Show("Carece de los permisos necesarios para acceder a ese directorio","Problema de permisos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        public void buscarPrimeraImagen()
        {
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Extension == ".png" || files[i].Extension == ".JPG")
                {
                    //System.Diagnostics.Debug.WriteLine("Una imagen en " + i);
                    //Reproductor.setImage(new Bitmap(files[i].FullName));
                    pictureBox1.Image = new Bitmap(files[i].FullName);
                    actual = i;
                    i = files.Length;
                }
            }
        }
        public void mostrarImagen()
        {
            if (carpeta != null)
            {
                if (actual == -1)
                {
                    buscarPrimeraImagen();
                }
                else
                {
                    bool cambioImagen = false;
                    for (int i = actual + 1; i < files.Length; i++)
                    {
                        if (files[i].Extension == ".png" || files[i].Extension == ".JPG")
                        {
                            //Reproductor.setImage(new Bitmap(files[i].FullName));
                            pictureBox1.Image = pictureBox1.Image = new Bitmap(files[i].FullName);
                            actual = i;
                            cambioImagen = true;
                            i = files.Length;
                        }
                        if (actual == files.Length-1)
                        {
                            actual = -1;
                        }
                        else
                        {
                            if (cambioImagen == false && i == files.Length - 1)
                            {
                                actual = -1;
                                buscarPrimeraImagen();
                            }
                        }
                    }
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            mostrarImagen();
            segundos++;
            Reproductor.Segundos = segundos;
            if (Convert.ToInt32(Math.Truncate((float)segundos / (float)60))>=100)
            {
                segundos = 0;
            }
        }

        private void Reproductor_PulsarBoton(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        private void Reproductor_DesbordaTiempo(object sender, EventArgs e)
        {
            float resultado = (float)segundos / (float)60;
            Reproductor.Minutos = Convert.ToInt32(Math.Truncate(resultado));
            Reproductor.Segundos = segundos % 60;
        }
    }
}
