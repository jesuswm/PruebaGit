using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GráficoDeBarras
{
    public enum Modo
    {
        automatico,manual
    }
    public enum Tipo
    {
        barras, lineas
    }
    [RefreshProperties(RefreshProperties.Repaint)]
    public partial class Grafico : Control
    {
        
        private List<int> valores=new List<int>();

        private string ejex="ejeX";

        private string ejey="ejeY";

        private Modo modo=Modo.manual;

        private Tipo tipo = Tipo.barras;

        private Color colorLinea = Color.Blue;

        private float maxEjey=100;
        private Color[] colores = new Color[3] { Color.Green,Color.Blue,Color.Yellow};
        [Category("Valores")]
        [Description("Nombre del eje x")]
        public string Ejey {
            get => ejey;
            set {
                ejey = value;
                this.Refresh();
            }
        }
        [Category("Valores")]
        [Description("Nombre del eje x")]
        public string Ejex {
            get => ejex;

            set {
                ejex = value;
                this.Refresh();
            }
        }
        [Category("Valores")]
        [Description("Lista de valores de la grafica")]
        public List<int> Valores {
            get => valores;
            set {
                valores = value;
                this.Refresh();
            }
        }
        [Category("Valores")]
        [Description("Espicifica el modo de la grafica")]
        public Modo Modo {
            get => modo;
            set
            {
                modo = value;
                this.Refresh();
            }
        }
        [Category("Valores")]
        [Description("Espicifica el tipo de grafica")]
        public Tipo Tipo
        {
            get => tipo;
            set
            {
                tipo = value;
                this.Refresh();
            }
        }
        [Category("Valores")]
        [Description("Maximo valor representado en modo manual")]
        public float MaxEjey
        {
            get => maxEjey;
            set {
                maxEjey = value;
                this.Refresh();
            }
        }
        [Category("Valores")]
        [Description("Color en el que se pinta la grafica en modo lineas")]
        public Color ColorLinea
        {
            get => colorLinea;
            set
            {
                colorLinea = value;
                this.Refresh();
            }
        }
        public Grafico()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            Font font = new Font(FontFamily.GenericSansSerif,10);
            g.DrawString(ejex, font, Brushes.Black, 0, this.Size.Height - font.Height);
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            g.DrawString(ejey, font, Brushes.Black, 0, 0, drawFormat);
            g.DrawLine(new Pen(Color.Black), font.Height, 0, font.Height, this.Size.Height - font.Height+1);
            g.DrawLine(new Pen(Color.Black), font.Height, this.Size.Height - font.Height + 1, this.Size.Width,this.Size.Height - font.Height + 1);
            if (valores.Count > 0)
            {
                if (Tipo == Tipo.barras)
                {
                    if (Modo == Modo.automatico)
                    {
                        int grosor = 5;
                        int separacion;
                        float maximo = 0;
                        foreach (int valor in valores)
                        {
                            if (maximo <= valor)
                            {
                                maximo = valor;
                            }
                        }
                        Size espacio = new Size(font.Height, this.Size.Width);
                        if (valores.Count != 1)
                        {
                            separacion = Size.Width / (valores.Count + 1);
                        }
                        else
                        {
                            separacion = Size.Width / 2;
                        }
                        for (int i = 0; i < valores.Count; i++)
                        {
                            if (valores[i] != 0)
                            {
                                //g.DrawLine(new Pen(colores[i % 3], grosor), font.Height + separacion * (i + 1), this.Size.Height - font.Height + 1, font.Height + separacion * (i + 1),0);
                                //int porcentaje = (maximo/ valores[i]);
                                float puntoY = (this.Size.Height - font.Height + 1) - (this.Size.Height - font.Height + 1) / (maximo / valores[i]);
                                g.DrawLine(new Pen(colores[i % 3], grosor), font.Height + separacion * (i + 1), this.Size.Height - font.Height + 1, font.Height + separacion * (i + 1), puntoY);
                            }
                        }
                    }
                    else
                    {
                        int grosor = 5;
                        int separacion;
                        Size espacio = new Size(font.Height, this.Size.Width);
                        if (valores.Count != 1)
                        {
                            separacion = Size.Width / (valores.Count + 1);
                        }
                        else
                        {
                            separacion = Size.Width / 2;
                        }
                        for (int i = 0; i < valores.Count; i++)
                        {
                            if (valores[i] != 0)
                            {
                                //g.DrawLine(new Pen(colores[i % 3], grosor), font.Height + separacion * (i + 1), this.Size.Height - font.Height + 1, font.Height + separacion * (i + 1),0);
                                //int porcentaje = (maximo/ valores[i]);
                                float puntoY = (this.Size.Height - font.Height + 1) - (this.Size.Height - font.Height + 1) / (MaxEjey / valores[i]);
                                if (puntoY >= 0)
                                {
                                    g.DrawLine(new Pen(colores[i % 3], grosor), font.Height + separacion * (i + 1), this.Size.Height - font.Height + 1, font.Height + separacion * (i + 1), puntoY);
                                }
                                else
                                {
                                    g.DrawLine(new Pen(Color.Red, grosor), font.Height + separacion * (i + 1), this.Size.Height - font.Height + 1, font.Height + separacion * (i + 1), 0);
                                }
                            }
                        }
                    }
                }
                else
                {
                    int separacion;
                    float maximo = 0;
                    foreach (int valor in valores)
                    {
                        if (maximo <= valor)
                        {
                            maximo = valor;
                        }
                    }
                    Size espacio = new Size(font.Height, this.Size.Width);
                    if (valores.Count != 1)
                    {
                        separacion = Size.Width / (valores.Count + 1);
                    }
                    else
                    {
                        separacion = Size.Width / 2;
                    }
                    float anterior = 0;
                    for (int i = 0; i < valores.Count; i++)
                    {
                        float puntoY;
                        if (valores[i] != 0)
                        {
                            puntoY = (this.Size.Height - font.Height + 1) - (this.Size.Height - font.Height + 1) / (maximo / valores[i]);
                        }
                        else
                        {
                            puntoY = this.Size.Height - font.Height + 1;
                        }
                        if (i == 0)
                        {
                            g.DrawLine(new Pen(colorLinea),font.Height, this.Size.Height - font.Height + 1, font.Height + separacion * (i + 1), puntoY);
                        }
                        else
                        {
                            g.DrawLine(new Pen(colorLinea), font.Height + separacion * (i), anterior, font.Height + separacion * (i + 1), puntoY);
                        }
                        anterior = puntoY;
                    }
                }

            }
        }
    }
}
