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

namespace FilesEjercicio1
{
    public partial class Form1 : Form
    {
        private DirectoryInfo a = null;
        Form secundario = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            if (Busqueda.Text.IndexOf('%') == 0 && Busqueda.Text.LastIndexOf('%') == Busqueda.Text.Length - 1)
            {
                try
                {
                    Directory.SetCurrentDirectory(Environment.GetEnvironmentVariable(Busqueda.Text.Replace('%', ' ').Trim()));
                    actualizarListas();
                }
                catch (System.ArgumentNullException)
                {
                    MessageBox.Show("No se ha encontrado la variable de entorno", "Variable de entorno no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    MessageBox.Show("La variable de entorno no se asocia a un directorio", "Variable de entorno no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Directory.SetCurrentDirectory(Busqueda.Text);
                    actualizarListas();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("No se ha encontrado la ruta especificada", "No se ha localizado la ruta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    MessageBox.Show("No se ha encontrado la ruta especificada", "No se ha localizado la ruta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.UnauthorizedAccessException)
                {
                    MessageBox.Show("No tiene los permisos necesarios", "No se tienen los permisos necesarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void actualizarListas()
        {
            a = new DirectoryInfo(Directory.GetCurrentDirectory());
            Text = a.FullName;
            if (Path.GetPathRoot(a.FullName) !=a.FullName) {
                listBox1.Items.Add("..");
            }
            foreach (DirectoryInfo dir in a.GetDirectories())
            {
                listBox1.Items.Add(dir.Name);
            }
            foreach(FileInfo file in a.GetFiles())
            {
                listBox2.Items.Add(file.Name);
            }
        }
        private void Busqueda_Enter(object sender, EventArgs e)
        {
            AcceptButton = this.boton;
        }


        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e) //permisos txt (o blouqeo) y caracteres
        {
            String archivo = (String)listBox2.SelectedItem;
            string contenido = null;
            StreamReader lector = null;
            if (Path.GetExtension(archivo) == ".txt")
            {
                DirectoryInfo a = new DirectoryInfo(Directory.GetCurrentDirectory());
                foreach(FileInfo file in a.GetFiles())
                {
                    if (archivo==file.Name)
                    {
                        using (lector=new StreamReader(file.FullName))
                        {
                            contenido = lector.ReadToEnd();
                        }
                    }
                }
                secundario = new Form2(contenido);
                secundario.ShowDialog();
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo a = new DirectoryInfo(Directory.GetCurrentDirectory());
            
                if (listBox1.SelectedIndex == 0 && a.FullName != Path.GetPathRoot(a.FullName))
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                Directory.SetCurrentDirectory(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
                actualizarListas();
            }
            else
            {
                try
                {
                    if (listBox1.SelectedIndex!=-1) {
                        Directory.SetCurrentDirectory(listBox1.Items[listBox1.SelectedIndex].ToString());
                        listBox1.Items.Clear();
                        listBox2.Items.Clear();
                        actualizarListas();
                    }
                }
                catch (System.UnauthorizedAccessException)
                {
                    MessageBox.Show("No tiene los permisos necesarios", "No se tienen los permisos necesarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
