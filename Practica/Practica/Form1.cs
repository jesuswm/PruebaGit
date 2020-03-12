using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        Form2 secundario = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Babrir_Click(object sender, EventArgs e)
        {
            switch (openFileDialog.ShowDialog())
            {
                case DialogResult.OK:
                    secundario = new Form2(openFileDialog.FileName);
                    System.Diagnostics.Debug.WriteLine(openFileDialog.FileName);
                    if (cmodal.Checked)
                    {
                        secundario.ShowDialog();
                    }
                    else
                    {
                        secundario.Show();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
