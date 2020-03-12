using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6Tema4_Forms_
{
    public partial class Form1 : Form
    {
        public readonly object l = new object();
        Juego.Delega d = new Juego.Delega(Juego.cambiaTexto);
        public bool display=true;
        public bool primera = true;
        public void cambiarText(String texto,Label l)
        {
            this.Invoke(d, texto, l);
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            Thread a = new Thread(() =>
            {
                Random generador= new Random();
                int r, g, b;
                while (true)
                {
                    while (display) {
                        r = generador.Next(0, 256);
                        g = generador.Next(0, 256);
                        Thread.Sleep(200);
                        b = generador.Next(0, 256);
                        lock (l)
                        {
                            if (display) {
                            Display.BackColor = Color.FromArgb(r, g, b);
                        }
                        else
                        {
                            
                                Monitor.Wait(l);
                            
                        }
                        }
                    }
                }
            });
            a.Start();
            Juego juego = new Juego(Tiradaj1, Tiradaj2,Puntuacion,this);
            juego.IniciarJugadores();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
