using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesEjercicio5
{
    public partial class Form1 : Form
    {
        private static readonly object l = new object();
        public delegate void delegado(String texto);
        public delegate void deleg();
        String ruta = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Ejercicio5Files.txt";
        delegado del;
        deleg enableTrue, enableFalse;
        //String[] extValidas = new String[] {".doc",".docx",".txt", ".HTML", ".HTM", ".nfo", ".rtf", ".wri", ".epub", ".log", ".dic" };
        public void agregarTexto(String texto)
        {
            tBusqueda.Text += texto;
        }
        public void enableFalseButon()
        {
            buscar.Enabled = false;
        }
        public void enableTrueButon()
        {
            buscar.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
            del = agregarTexto;
            enableTrue =enableTrueButon;
            enableFalse =enableFalseButon;
            try
            {
                using (StreamReader leer = new StreamReader(ruta))
                {
                    textensiones.Text = leer.ReadToEnd();
                }
                if (textensiones.Text.Trim()=="")
                {
                    textensiones.Text = ".txt";
                }
            }
            catch (FileNotFoundException) {
                textensiones.Text = ".txt";
            }
        }
        
        
        public void buscarEnArchivo(FileInfo file,String busqueda){
            //buscar.Enabled = false;
            //this.Invoke(enableFalse);
            String contenido=null;
            int cont = 0;
            using (StreamReader leer=new StreamReader(file.FullName))
            {
                contenido = leer.ReadToEnd();
            }
            if (cMayusculas.Checked)
            {
                contenido=contenido.ToLower();
                busqueda = busqueda.ToLower();
            }
            //C:\Users\Jesus\Desktop\Cosa
            //System.Diagnostics.Debug.WriteLine(contenido);
            while (contenido.Contains(busqueda)) {
                //buscar.Enabled = false;
                //this.Invoke(enableFalse);
                if (contenido.Length>1) { 
                    contenido = contenido.Substring(contenido.IndexOf(busqueda) + 1);
                    System.Diagnostics.Debug.WriteLine(contenido);
                }
                else
                {
                    break;
                }
                cont++;
            }
            System.Diagnostics.Debug.WriteLine(String.Format("Numero de apariciones en {0} {1}", file.FullName, cont));
            lock (l)
            {
                 this.Invoke(del,String.Format("Numero de apariciones en {0} {1}\r\n", file.Name, cont));
                //buscar.Enabled = true;
                //this.Invoke(enableTrue);
            }
        }
        private void Buscar_Click(object sender, EventArgs e)
        {
            String[] extensiones = textensiones.Text.Split(',');
            //foreach (string ext in extensiones)
            //{
            //    System.Diagnostics.Debug.WriteLine(ext);
            //}
            try
            {
                tBusqueda.Text = "";
                DirectoryInfo directory = new DirectoryInfo(tdirectorio.Text);
                String busqeda = tpalabra.Text;
                System.Diagnostics.Debug.WriteLine(busqeda);
                if (directory.Exists)
                {
                    if (busqeda.Trim()!="") {
                        foreach (FileInfo file in directory.GetFiles())
                        {
                            if (extensiones.Contains(file.Extension))
                            {
                                new Thread(() => { buscarEnArchivo(file, busqeda); }).Start();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha introducido una cadena", "No se ha introducido una cadena", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No se encuentra la carpeta", "No existe o no es una carpeta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (System.ArgumentException) {
                MessageBox.Show("No se encuentra la carpeta", "No existe o no es una carpeta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter escribir = new StreamWriter(ruta))
            {
                escribir.Write(textensiones.Text);
            }
            Environment.Exit(0);
        }
    }
}
