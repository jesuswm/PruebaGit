using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio6Tema4_Forms_
{
    class Juego
    {
        System.Windows.Forms.Label ljugador1, ljugador2, puntuacion;
        bool fin=false;
        Thread player1;
        Thread player2;
        Form1 formulario;
        Random generador = new Random();
        int puntos = 0;
        private readonly object l = new object();
        public delegate void Delega(string texto, System.Windows.Forms.Label t);
        public static void cambiaTexto(string texto, System.Windows.Forms.Label t)
        {
            t.Text=texto;
        }
        public Juego(System.Windows.Forms.Label ljugador1, System.Windows.Forms.Label ljugador2, System.Windows.Forms.Label puntuacion, Form1 formulario)
        {
            this.ljugador1 = ljugador1;
            this.ljugador2 = ljugador2;
            this.formulario = formulario;
            this.puntuacion = puntuacion;
        }
        public void hilos(System.Windows.Forms.Label ljugador,int objetivo,bool aumentar,String nombre)
        {
            Thread a = new Thread(() =>
              {
                  while (!fin)
                  {
                      int tirada = generador.Next(1, 11);
                      formulario.cambiarText("" + tirada, ljugador);
                      if (tirada == 5 || tirada == 7)
                      {
                          lock (l)
                          {
                              if (!fin)
                              {
                                  if (formulario.display)
                                  {
                                      if (aumentar)
                                      {
                                          puntos++;
                                          formulario.cambiarText("Puntos: " + puntos, puntuacion);
                                          formulario.display = false;
                                      }
                                      else
                                      {
                                          if (!formulario.primera) {
                                              puntos = puntos - 5;
                                          }
                                          else
                                          {
                                              puntos --;
                                              formulario.primera = false;
                                          }
                                          formulario.cambiarText("Puntos: " + puntos, puntuacion);
                                      }
                                  }
                                  else
                                  {
                                      if (aumentar)
                                      {
                                          puntos = puntos + 5;
                                          formulario.cambiarText("Puntos: " + puntos, puntuacion);
                                      }
                                      else
                                      {
                                          puntos--;
                                          formulario.cambiarText("Puntos: " + puntos, puntuacion);
                                          formulario.display = true;
                                          lock (formulario.l)
                                          {
                                              Monitor.Pulse(formulario.l);
                                          }
                                      }
                                  }
                                  if (aumentar)
                                  {
                                      if (puntos >= objetivo)
                                      {
                                          fin = true;
                                          formulario.cambiarText("Gana el " + nombre, puntuacion);
                                      }
                                  }
                                  else
                                  {
                                      if (puntos <= objetivo)
                                      {
                                          fin = true;
                                          formulario.cambiarText("Gana el jugador2", puntuacion);
                                      }
                                  }
                              }
                          }
                      }
                      tirada = generador.Next(100, tirada * 100 + 1);
                      Thread.Sleep(tirada);
                  }
              });
            a.Start();
        }
        public void IniciarJugadores()
        {
            //player1 = new Thread(() =>
            //  {
            //      while (!fin)
            //      {
            //          int tirada = generador.Next(1, 11);
            //          formulario.cambiarText("" + tirada, ljugador1);
            //          if (tirada==5 || tirada==7)
            //          {
            //              lock (l)
            //              {
            //                  if (!fin) {
            //                      if (formulario.display)
            //                      {
            //                          puntos++;
            //                          formulario.cambiarText("Puntos: " + puntos, puntuacion);
            //                          formulario.display = false;
            //                      }
            //                      else
            //                      {
            //                          puntos = puntos + 5;
            //                          formulario.cambiarText("Puntos: " + puntos, puntuacion);
            //                      }
            //                      if (puntos>=20)
            //                      {
            //                          fin = true;
            //                          formulario.cambiarText("Gana el jugador1", puntuacion);
            //                      }
            //                  }
            //              }
            //          }
            //          tirada= generador.Next(100, tirada*100+1);
            //          Thread.Sleep(tirada);
            //          //Thread.Sleep(2500);
            //      }
            //  });
            //player2 = new Thread(() =>
            //{
            //    while (!fin)
            //    {
            //        int tirada = generador.Next(1, 11);
            //        formulario.cambiarText(""+tirada, ljugador2);
            //        if (tirada == 5 || tirada == 7)
            //        {
            //            lock (l)
            //            {
            //                if (!fin)
            //                {
            //                    if (!formulario.display)
            //                    {
            //                        puntos--;
            //                        formulario.cambiarText("Puntos: " + puntos, puntuacion);
            //                        formulario.display = true;
            //                    }
            //                    else
            //                    {
            //                        puntos = puntos - 5;
            //                        formulario.cambiarText("Puntos: " + puntos, puntuacion);
            //                    }
            //                    if (puntos <= -20)
            //                    {
            //                        fin = true;
            //                        formulario.cambiarText("Gana el jugador2", puntuacion);
            //                    }
            //                }
            //            }
            //        }
            //        tirada = generador.Next(100, tirada * 100 + 1);
            //       Thread.Sleep(tirada);
            //Thread.Sleep(2500);
            //    }
            // });
            // player1.Start();
            // player2.Start();
            hilos(ljugador1,20,true,"Jugador1");
            hilos(ljugador2, -20, false, "Jugador2");
        }
    }
}
