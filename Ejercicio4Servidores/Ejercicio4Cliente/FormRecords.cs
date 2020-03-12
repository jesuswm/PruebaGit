using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio4Servidores;

namespace Ejercicio4Cliente
{
    public partial class FormRecords : Form
    {
        public FormRecords()
        {
            InitializeComponent();
        }
        public FormRecords(Record[] records)
        {
            InitializeComponent();
            textBox1.Text += String.Format("{0,-8}{1,-12}{2,-10}\r\n","Nombre","Tiempo","Ip");
            foreach(Record recor in records)
            {
                if (recor != null)
                {
                    TimeSpan tiempo = TimeSpan.FromSeconds(recor.tiempo);
                    textBox1.Text += String.Format("{0,-8}{1:D2}h:{2:D2}m:{3:D2}s {4,-10}\r\n", recor.nombre, tiempo.Hours, tiempo.Minutes, tiempo.Seconds, recor.ip);
                }
            }
        }
    }
}
