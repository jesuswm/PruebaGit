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
    public enum eTipo { Numérico, Textual }
    public partial class ValidateTextB : UserControl
    {
        public ValidateTextB()
        {
            InitializeComponent();
        }
        eTipo tipo = eTipo.Numérico;
        bool valido;
        private bool Valido{
            set
            {
                valido = value;
                Refresh();
            }
            get
            {
                return valido;
            }
        }
        [Category("Propiedades")]
        [Description("Cambia los valores validos del textBox")]
        public eTipo Tipo
        {
            set
            {
                tipo = value;
                Refresh();
            }
            get
            {
                return tipo;
            }
        }
        [Category("Propiedades")]
        [Description("Cambia el valor del textbox del componente")]
        public string Texto
        {
            set
            {
                this.textBox1.Text = value;
            }
            get
            {
                return textBox1.Text;
            }
        }
        [Category("Propiedades")]
        [Description("Establece el valor multiline del texbox")]
        public bool Multilinea
        {
            set
            {
                this.textBox1.Multiline = value;
                OnSizeChanged(new EventArgs());
            }
            get
            {
                return this.textBox1.Multiline;
            }
        }
        [Category("Eventos")]
        [Description("Evento que se lanza cuando se cambia el texto del textBox del componente")]
        public event System.EventHandler CambiaTextBox;
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (textBox1.Multiline  )
            {
                textBox1.Size = new Size(this.Size.Width - 20, this.Size.Height - 20);
            }
            else
            {
                textBox1.Size = new Size(this.Size.Width - 20, textBox1.Size.Height);
                this.Size = new Size(this.Size.Width, textBox1.Size.Height + 20);
            }
        }
        public void comprobarValido()
        {
            bool valido = true;
            if (!(textBox1.Text == ""))
            {
                foreach (char letra in textBox1.Text.Trim())
                {
                    if (tipo == eTipo.Numérico)
                    {
                        if (!char.IsNumber(letra))
                            
                        {
                            valido = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!char.IsLetter(letra) && !char.IsWhiteSpace(letra))
                        {
                            valido = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                valido = false;
            }
            Valido = valido;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            SolidBrush color;
            Rectangle fondo = new Rectangle(5, 5, this.Size.Width - 10, this.Size.Height - 10);
            if (!Valido)
            {
                color = new SolidBrush(Color.Red);
                g.FillRectangle(color, fondo);
            }
            else {
                color = new SolidBrush(Color.Green);
                g.FillRectangle(color, fondo);
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            comprobarValido();
            CambiaTextBox?.Invoke(this, new EventArgs());
        }
    }
}
