using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujoAhorcado
{
    [RefreshProperties(RefreshProperties.Repaint)]
    public partial class DibujoAhorcado : Control
    {
        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad errores cambia")]
        public event EventHandler CambiaError;
        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad errores llega a 6")]
        public event EventHandler Ahorcado;
        int errores;
        [Category("Propiedad")]
        [Description("Indica el nuemro de errores")]
        public int Errores {
            get {
                return errores;
            } set {
                if (value >= 0 && value <= 6)
                {
                    if (CambiaError != null)
                    {
                        CambiaError(this, new EventArgs());
                    }
                    errores = value;
                    this.Refresh();
                    if (errores == 6)
                    {
                        if (Ahorcado != null)
                        {
                            Ahorcado(this, new EventArgs());
                        }
                    }
                }
            }
        }

        public DibujoAhorcado()
        {
            InitializeComponent();
            MinimumSize = new Size(100,150);
        }
        public override Size MinimumSize {
            get {
                return base.MinimumSize;
            }
            set {
                if (((Size)value).Width >= 100 && ((Size)value).Height >= 150)
                {
                    base.MinimumSize = value;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int grosor=1;
            int offsetY = 15;
            Rectangle cabeza= new Rectangle(new Point((this.Width / 2) - (this.Width / 3) / 2, offsetY), new Size(this.Width / 3, this.Height / 4));
            switch (errores)
            {
                case 0:
                    g.DrawLine(new Pen(Color.Black,grosor*3),new Point(this.Width-grosor*3,this.Height),new Point(this.Width-grosor * 3, 0));
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width - grosor * 3, 0),new Point(this.Width/2,0));
                    g.DrawLine(new Pen(Color.Black, grosor * 3),new Point(this.Width / 2, 0), new Point(this.Width / 2, offsetY));
                    break;
                case 1:
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width - grosor * 3, this.Height), new Point(this.Width - grosor * 3, 0));
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width - grosor * 3, 0), new Point(this.Width / 2, 0));
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width / 2, 0), new Point(this.Width / 2, offsetY));
                    g.DrawEllipse(new Pen(Color.Black, grosor), new Rectangle(new Point((this.Width / 2) - (this.Width / 3) / 2, offsetY), new Size(this.Width / 3, this.Height / 4)));
                    break;
                case 2:
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width - grosor * 3, this.Height), new Point(this.Width - grosor * 3, 0));
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width - grosor * 3, 0), new Point(this.Width / 2, 0));
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width / 2, 0), new Point(this.Width / 2, offsetY));
                    g.DrawEllipse(new Pen(Color.Black, grosor), new Rectangle(new Point((this.Width / 2) - (this.Width / 3) / 2, offsetY), new Size(this.Width / 3, this.Height / 4)));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), this.Height / 4 + grosor+offsetY), new Point((this.Width / 2), cabeza.Height * 3));
                    break;
                case 3:
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width - grosor * 3, this.Height), new Point(this.Width - grosor * 3, 0));
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width - grosor * 3, 0), new Point(this.Width / 2, 0));
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width / 2, 0), new Point(this.Width / 2, offsetY));
                    g.DrawEllipse(new Pen(Color.Black, grosor), new Rectangle(new Point((this.Width / 2) - (this.Width / 3) / 2, offsetY), new Size(this.Width / 3, this.Height / 4)));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), this.Height / 4 + grosor + offsetY), new Point((this.Width / 2), cabeza.Height * 3));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), cabeza.Height * 2), new Point((this.Width / 2) + (this.Width / 3) / 2, this.Height / 4 + grosor+offsetY));
                    break;
                case 4:
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width - grosor * 3, this.Height), new Point(this.Width - grosor * 3, 0));
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width - grosor * 3, 0), new Point(this.Width / 2, 0));
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width / 2, 0), new Point(this.Width / 2, offsetY));
                    g.DrawEllipse(new Pen(Color.Black, grosor), new Rectangle(new Point((this.Width / 2) - (this.Width / 3) / 2, offsetY), new Size(this.Width / 3, this.Height / 4)));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), this.Height / 4 + grosor + offsetY), new Point((this.Width / 2), cabeza.Height * 3));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), cabeza.Height * 2), new Point((this.Width / 2) + (this.Width / 3) / 2, this.Height / 4 + grosor + offsetY));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), cabeza.Height * 2), new Point((this.Width / 2) - (this.Width / 3) / 2, this.Height / 4 + grosor + offsetY));
                    break;
                case 5:
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width - grosor * 3, this.Height), new Point(this.Width - grosor * 3, 0));
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width - grosor * 3, 0), new Point(this.Width / 2, 0));
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width / 2, 0), new Point(this.Width / 2, offsetY));
                    g.DrawEllipse(new Pen(Color.Black, grosor), new Rectangle(new Point((this.Width / 2) - (this.Width / 3) / 2, offsetY), new Size(this.Width / 3, this.Height / 4)));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), this.Height / 4 + grosor + offsetY), new Point((this.Width / 2), cabeza.Height * 3));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), cabeza.Height * 2), new Point((this.Width / 2) + (this.Width / 3) / 2, this.Height / 4 + grosor + offsetY));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), cabeza.Height * 2), new Point((this.Width / 2) - (this.Width / 3) / 2, this.Height / 4 + grosor + offsetY));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), cabeza.Height * 3), new Point((this.Width / 2) + (this.Width / 3) / 2, this.Height-offsetY));
                    break;
                case 6:
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width - grosor * 3, this.Height), new Point(this.Width - grosor * 3, 0));
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width - grosor * 3, 0), new Point(this.Width / 2, 0));
                    g.DrawLine(new Pen(Color.Black, grosor * 3), new Point(this.Width / 2, 0), new Point(this.Width / 2, offsetY));
                    g.DrawEllipse(new Pen(Color.Black, grosor), new Rectangle(new Point((this.Width / 2) - (this.Width / 3) / 2, offsetY), new Size(this.Width / 3, this.Height / 4)));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), this.Height / 4 + grosor + offsetY), new Point((this.Width / 2), cabeza.Height * 3));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), cabeza.Height * 2), new Point((this.Width / 2) + (this.Width / 3) / 2, this.Height / 4 + grosor + offsetY));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), cabeza.Height * 2), new Point((this.Width / 2) - (this.Width / 3) / 2, this.Height / 4 + grosor + offsetY));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), cabeza.Height * 3), new Point((this.Width / 2) + (this.Width / 3) / 2, this.Height-offsetY));
                    g.DrawLine(new Pen(Color.Black, grosor), new Point((this.Width / 2), cabeza.Height * 3), new Point((this.Width / 2) - (this.Width / 3) / 2, this.Height-offsetY));
                    break;
            }
        }
    }
}
