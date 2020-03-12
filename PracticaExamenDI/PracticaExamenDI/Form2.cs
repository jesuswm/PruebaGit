using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaExamenDI
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            btnAceptar.Select();
        }
        public String getTpin()
        {
            return txtPin.Text;
        }
        public void setLblError(String t)
        {
            lblError.Text = t;
        }
        public bool getcheck()
        {
            return chkCompleta.Checked;
        }
    }
}
