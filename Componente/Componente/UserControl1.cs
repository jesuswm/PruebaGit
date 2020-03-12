using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente
{
    public enum ePosicion
    {
        derecha,izquierda
    }
    public partial class UserControl1 : UserControl
    {
        private ePosicion pos = ePosicion.derecha;
        public ePosicion Pos
        {
            set
            {
                pos = value;
                this.Refresh();
            }
            get
            {
                return pos;
            }
        }
        [Category("Nada")]
        [Description("Cambia el texto del text box")]
        public string TextoTextBox
        {
            set
            {
                textBox1.Text=value;
            }
            get
            {
                return textBox1.Text;
            }
        }
        [Category("Nada")]
        [Description("evento que se lanza cuando cambia el texto del text box")]
        event EventHandler cambiaTexto;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            cambiaTexto(this,new EventArgs());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Pos==ePosicion.derecha)
            {
                label1.Location=new Point(3,6);
                label1.Size = label1.PreferredSize;
                textBox1.Location = new Point(label1.PreferredSize.Width + this.Font.Height, 6);
                this.Size = new Size(label1.PreferredSize.Width + this.Font.Height + 3+textBox1.Size.Width+3, textBox1.PreferredSize.Height + 12);
            }
            else
            {

            }
        }
    }
}
