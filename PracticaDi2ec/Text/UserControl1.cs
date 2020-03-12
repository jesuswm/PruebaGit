using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidateTextBox
{
    public enum eTipo
    {
        Texto,Numero
    }
    public partial class UserControl1 : UserControl
    {
        private eTipo tipo = eTipo.Texto;
        public eTipo Tipo{
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
                Refresh();
            }
        }
        public string TextB{
            set
            {
                textBox1.Text = value;
                Refresh();
            }
            get
            {
                return textBox1.Text;
            }
        }
        public bool Multiline
        {
            set
            {
                textBox1.Multiline = value;
            }
            get
            {
                return textBox1.Multiline;
            }
        }
        public UserControl1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Multiline)
            {
                textBox1.Size = new Size(this.Width - 20, this.Height - 20);
            }
            else
            {
                this.Size = new Size(this.Size.Width, textBox1.Height + 20);
                textBox1.Size = new Size(this.Width - 20, this.Height - 20);
            }
            bool valido = true;
            if (Tipo == eTipo.Numero)
            {
                foreach(char caracter in TextB)
                {
                    if (!Char.IsDigit(caracter))
                    {
                        valido = false;
                    }
                }
            }
            else
            {
                foreach (char caracter in TextB)
                {
                    if (!Char.IsLetter(caracter))
                    {
                        valido = false;
                    }
                }
            }
            if (valido)
            {
                e.Graphics.FillRectangle(Brushes.Green, 5, 5, this.Size.Width - 10, this.Size.Height - 10);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Red,5,5,this.Size.Width-10, this.Size.Height - 10);
            }
        }
    }
}
