using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtiquetaAviso
{
    public enum eMarca
    {
        Nada,
        Cruz,
        Circulo,
        Imagen
    }

    public partial class etiquetaAviso : Control
    {
        private eMarca marca = eMarca.Nada;
        private bool fondoGradiante;
        Color incioGradiante=Color.Blue;
        Color finGradiante=Color.White;
        private Image imagenMarca;
        private int xmarca=0;
        private int ymarca=0;

        [Category("Propiedad")]
        [Description("Cambia el valor de la marca")]
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get { return marca; }
        }

        [Category("Propiedad")]
        [Description("Activa o desactiva el fondo gradiante")]
        public bool FondoGradiante{
            set
            {
                fondoGradiante = value;
                this.Refresh();
            }
            get { return fondoGradiante; }
        }

        [Category("Propiedad")]
        [Description("Primer color del fondo priemer color del  fondo gradiante")]
        public Color IncioGradiante
        {
            set
            {
                incioGradiante = value;
                this.Refresh();
            }
            get { return incioGradiante; }
        }

        [Category("Propiedad")]
        [Description("Primer color del fondo segundo color del  fondo gradiante")]
        public Color FinGradiante
        {
            set
            {
                finGradiante = value;
                this.Refresh();
            }
            get { return finGradiante; }
        }

        [Category("Propiedad")]
        [Description("Permite seleccionar la imagen para el modo de marca con imagen")]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
                this.Refresh();
            }
            get { return imagenMarca; }
        }

        [Category("custon")]
        [Description("Se lanza cuando se hace click sobre la marca")]
        public event System.EventHandler ClickEnMarca;

        public etiquetaAviso()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
                             //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
                             // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            if (fondoGradiante)
            {
                System.Drawing.Drawing2D.LinearGradientBrush fondo= new System.Drawing.Drawing2D.LinearGradientBrush(new Point(0, this.Size.Height / 2), new Point(this.Size.Width, this.Size.Height / 2),IncioGradiante,FinGradiante);
                g.FillRectangle(fondo,0,0,Size.Width,Size.Width);
            }
            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,this.Font.Height, this.Font.Height);
                    xmarca = this.Font.Height+grosor+grosor;
                    ymarca = this.Font.Height+grosor+grosor;
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 5;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, this.Font.Height, this.Font.Height);
                    g.DrawLine(lapiz, this.Font.Height, grosor, grosor,this.Font.Height);
                    xmarca = this.Font.Height+grosor;
                    ymarca = this.Font.Height+grosor;
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case eMarca.Imagen:
                    if (imagenMarca != null)
                    {
                        Rectangle rectangle = new Rectangle(0, 0, this.Font.Height, this.Size.Height);
                        //offsetY = Size.Height / 2;
                        offsetX = this.Font.Height;
                        xmarca = this.Font.Height;
                        ymarca = this.Size.Height;
                        //new Rectangle(0,0,this.Size.Width,this.Size.Height)
                        g.DrawImage(imagenMarca, rectangle);
                    }
                    break;
            }
            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (e != null)
            {
                base.OnMouseClick(e);
            }
            if (marca != eMarca.Nada)
            {
                if (ClickEnMarca !=null)
                {
                    int x=e.X;
                    int y=e.Y;
                    if (x<=xmarca && y<=ymarca) {
                        ClickEnMarca(this, new EventArgs());
                    }
                }
            }
        }
    }
}

