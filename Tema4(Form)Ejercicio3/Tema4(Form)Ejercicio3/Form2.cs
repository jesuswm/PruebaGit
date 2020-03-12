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

namespace Tema4_Form_Ejercicio3
{
    public partial class Form2 : Form
    {
        bool aux=false;
        public Form2(String imagen)
        {
            InitializeComponent();

            try
            {
                pictureBox1.Image = Image.FromFile(imagen);
                Text = Path.GetFileName(imagen);
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show("El archivo seleccionado no es una imagen","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ClientSize=new Size(pictureBox1.Width,pictureBox1.Height);
            aux = true;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            if (aux)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            }
        }
    }
}
