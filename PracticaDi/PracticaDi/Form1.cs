using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDi
{
    public partial class Form1 : Form
    {
        struct datos
        {
            public String nombre,descripcion,nota,tipo;
            public Urgencia urgencia;
            public datos(String nombre,String descripcion,String nota,String tipo,Urgencia urgencia)
            {
                this.nombre = nombre;
                this.descripcion = descripcion;
                this.nota = nota;
                this.tipo = tipo;
                this.urgencia = urgencia;
            }
        }
        enum Urgencia { Ya,Hoy,Mañana };
        Urgencia urg = Urgencia.Ya;
        int[] pin = { 1111, 2222, 3333, 4444, 5555 };
        String tipo= "Publica";
        List<datos> lista = new List<datos>();
        imput pedirdatos = null;
        int intentos=1;
        public Form1()
        {
            InitializeComponent();
            DialogResult dresul = DialogResult.None;
            Form2 secundario = new Form2();
            while (dresul!=DialogResult.OK && intentos<=3)
            {
                dresul=secundario.ShowDialog();
                if (dresul != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    try
                    {
                        if (!pin.Contains(Convert.ToInt32(secundario.txtPin.Text)))
                        {
                            secundario.lblError.Text = "Pin erroneo";
                            dresul = DialogResult.Abort;
                        }
                    }
                    catch (System.FormatException)
                    {
                        secundario.lblError.Text = "Porfavor introduzca solo valores numericos";
                        dresul = DialogResult.Abort;
                    }
                }
                intentos++;
            }
            if (intentos>3 && dresul==DialogResult.Abort)
            {
                Environment.Exit(0);
            }
            if (!secundario.checkBox1.Checked)
            {
                GTipo.Visible = false;
                gUrgencia.Visible = false;
            }
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
            if (MessageBox.Show("Desea cerrar el formulario","¿Salir?",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tipo_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                tipo = ((RadioButton)sender).Tag.ToString();
            }
        }
        private void Urgencia_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                urg = (Urgencia)((RadioButton)sender).Tag;
            }
        }

        private void BtnAlmacenar_Click(object sender, EventArgs e)
        {
            lista.Add(new datos(txtNombre.Text,txtDestinatario.Text,txtNota.Text,tipo,urg));
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            String res=null;
            pedirdatos = new imput();
            if (pedirdatos.ShowDialog()==DialogResult.OK) {
                foreach (Control componente in pedirdatos.Controls)
                {
                    if (componente.GetType()==typeof(TextBox)) {
                        res = ((TextBox)componente).Text;
                    }
                }
                try
                {
                    lista.RemoveAt(Convert.ToInt32(res));
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("No se ha introducido un numero", "Problema de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("No existe esa posicion", "Imposible eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            txtNota.Text = "";
            foreach (datos info in lista)
            {
                txtNota.Text +=String.Format("Nombre: {0} Descripcion: {1} Nota: {2} Tipo: {3} Urgencia: {4}\r\n*******************\r\n", info.nombre,info.descripcion,info.nota,info.tipo,info.urgencia) ;
            }
        }
    }
}
