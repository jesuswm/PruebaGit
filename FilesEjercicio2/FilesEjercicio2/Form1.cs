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
namespace FilesEjercicio2
{
    public partial class Form1 : Form
    {
        bool cancelar;
        String contenido = "";
        FileInfo file = null;
        StreamReader leer = null;
        StreamWriter escribir = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void guardarCambios(out bool cancelar){
            cancelar = false;
            if (contenido != editor.Text)
            {
                switch (MessageBox.Show("Desea guardar los cambios en este documento", 
                    "¿Guardar?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        if (DialogResult.OK == saveFileDialog1.ShowDialog())
                        {
                            file = new FileInfo(saveFileDialog1.FileName);
                            using (escribir = new StreamWriter(file.FullName))
                            {
                                escribir.Write(editor.Text);
                                contenido = editor.Text;
                            }
                        }
                        else
                        {
                            cancelar = true;
                        }
                        break;
                    case DialogResult.No:
                        
                        break;
                    case DialogResult.Cancel:
                        cancelar = true;
                        break;
                }
            }
        }
        private void Bnuevo_Click(object sender, EventArgs e)
        {
            if (!editor.Enabled)
            {
                editor.Enabled = true;
            }
            else
            {
                guardarCambios(out cancelar);
                if (!cancelar)
                {
                    editor.Text = "";
                    contenido = "";
                }
            }
        }

        private void BAbrir_Click(object sender, EventArgs e)
        {
            
            guardarCambios(out cancelar);
            if (!cancelar)
            {
                switch (openFileDialog1.ShowDialog())
                {
                    case DialogResult.OK:
                        file = new FileInfo(openFileDialog1.FileName);
                        using (leer = new StreamReader(file.FullName))
                        {
                            contenido = leer.ReadToEnd();
                            editor.Text = contenido;
                        }
                        if (!editor.Enabled)
                        {
                            editor.Enabled = true;
                        }
                        break;
                    case DialogResult.Cancel:
                        
                        break;
                };
            }
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            if (editor.Enabled)
            {
                if (DialogResult.OK == saveFileDialog1.ShowDialog())
                {
                    file = new FileInfo(saveFileDialog1.FileName);
                    using (escribir = new StreamWriter(file.FullName))
                    {
                        escribir.Write(editor.Text);
                        contenido = editor.Text;
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna archivo en el editor","No se ha podido guardar",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
