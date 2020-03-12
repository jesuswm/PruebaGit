using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4Cliente
{
    public partial class CambiarServidor : Form
    {
        public CambiarServidor()
        {
            InitializeComponent();
        }
        public CambiarServidor(string ip, string puerto)
        {
            InitializeComponent();
            this.ip.Text = ip;
            this.port.Text = puerto;
        }
    }
}
