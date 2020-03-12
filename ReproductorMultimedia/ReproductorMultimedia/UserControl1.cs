using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ReproductorMultimedia
{
    public partial class UserControl1 : UserControl
    {
        [Category("Custom")]
        [Description("Se lanza cuando se pulsa el boton del componente")]
        public event System.EventHandler PulsarBoton;
        [Category("Custom")]
        [Description("Se lanza cuando se desbordan los valores de segundos")]
        public event System.EventHandler DesbordaTiempo;
        private bool activo=false;
        public UserControl1()
        {
            InitializeComponent();
        }
        private int segundos=0;
        [Category("Appearance")]
        [Description("Establece los segundos")]
        public int Segundos
        {
            get
            {
                return segundos;
            }
            set
            {
                if (value < 60)
                {
                    segundos = value;
                }
                else
                {
                    //int resultado = value /60;
                    //Minutos = resultado;
                    //segundos = value % 60;
                    DesbordaTiempo?.Invoke(this, new EventArgs());
                }
                label1.Text = String.Format("{0,2:D2}:{1,2:D2}", minutos, segundos);
            }
        }
        private int minutos=0;
        [Category("Appearance")]
        [Description("Establece los minutos")]
        public int Minutos
        {
            get
            {
                return minutos;
            }
            set
            {
                if (value < 100)
                {
                    minutos = value;
                }
                else
                {
                    minutos = 0;
                   
                }
                label1.Text = String.Format("{0,2:D2}:{1,2:D2}", minutos, segundos);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (activo == true)
            {
                button1.Image = Resource1.ImagenPlay;
                activo = false;
            }
            else
            {
                button1.Image = Resource1.ImagenStop;
                activo = true;
            }
            if (PulsarBoton != null)
            {
                PulsarBoton(this, new EventArgs());
            }
        }
    }

}
