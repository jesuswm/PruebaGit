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
    public partial class Form2 : Form
    {
        public Form2(String ruta)
        {
            InitializeComponent();
            Bitmap imagen = new Bitmap(ruta);
            ClientSize=imagen.Size;
            pictureBox1.Image=imagen;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Dock = DockStyle.Fill;
        }
    }
}
