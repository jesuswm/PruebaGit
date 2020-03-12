using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Form_Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if(!(DialogResult.Cancel== file.ShowDialog())){
                String a = file.FileName;
                if (modal.Checked)
                {
                    Form2 form2 = new Form2(a);
                    try
                    {
                        form2.ShowDialog();
                    }
                    catch (ObjectDisposedException)
                    {
                    }
                }
                else
                {
                    Form2 form2 = new Form2(a);
                    try
                    {
                        form2.Show();
                    }
                    catch (ObjectDisposedException)
                    {
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Quiere cerrar el programa", "¿Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No){
                e.Cancel = true;
            }
        }
    }
}
