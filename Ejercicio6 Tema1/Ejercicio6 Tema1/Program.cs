using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_Tema1
{
    class cordenadas
    {
        public int x;
        public int y;
        public cordenadas(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public Boolean compCordenadas(cordenadas a)
        {
            if (a.x == x && a.y == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Juego
    {
        int maxY;
        int maxX;
        int minY;
        int minX;
        int distanciaCpu;
        public Juego()
        {
            maxY = 11;
            maxX = 10;
            minY = 2;
            minX = 1;
            distanciaCpu = 15;
        }
        public Juego(int maxY,int maxX,int minY,int minX,int distanciaCpu)
        {
            this.maxY = maxY;
            this.maxX = maxX;
            this.minY = minY;
            this.minX = minX;
            this.distanciaCpu = distanciaCpu;
        }
        public Boolean comprobarFin(ArrayList intentos,ArrayList objetivo)
        {
            if (intentos.Count >= 2)
            {
                return ((cordenadas)intentos[intentos.Count - 1]).compCordenadas((cordenadas)objetivo[0]);
            }
            else
            {
                return false;
            }
        }
        public void pintarBorde(int inicioX, int inicioY, int ancho)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(inicioX - 1, inicioY - 1);
            Console.Write("+");
            for (int i = 0; i < ancho; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            for (int i = 0; i < ancho; i++)
            {
                Console.SetCursorPosition(inicioX - 1, inicioY + i);
                Console.Write("|");
                Console.SetCursorPosition(inicioX + ancho, inicioY + i);
                Console.Write("|");
            }
            Console.SetCursorPosition(inicioX - 1, inicioY + ancho);
            Console.Write("+");
            for (int i = 0; i < ancho; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }
        public void pintarIntentos(ArrayList intentos, ArrayList intentosCpu)
        {

            for (int i = 0; i < intentos.Count; i++)
            {
                Console.SetCursorPosition(((cordenadas)intentos[i]).x, ((cordenadas)intentos[i]).y);
                if (i == 0)
                {
                    Console.SetCursorPosition(((cordenadas)intentos[i]).x+distanciaCpu, ((cordenadas)intentos[i]).y);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("B");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("X");
                }
            }
            for (int i = 0; i < intentosCpu.Count; i++)
            {
                Console.SetCursorPosition(((cordenadas)intentosCpu[i]).x+distanciaCpu, ((cordenadas)intentosCpu[i]).y);
                if (i == 0)
                {
                    Console.SetCursorPosition(((cordenadas)intentosCpu[i]).x, ((cordenadas)intentosCpu[i]).y);
                    Console.ForegroundColor = ConsoleColor.Red;
                    //Console.Write("B");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X");
                }
            }
        }
        public Boolean turnoCpu(ArrayList intentosCpu, ArrayList intentos)
        {
            Random generador = new Random();
            pintarBorde(minX+distanciaCpu,minY,10);
            int x, y, incio;
            incio = intentosCpu.Count;
            x = generador.Next(minX, maxX + 1);
            y = generador.Next(minY, maxY + 1);
            Console.SetCursorPosition(x, y);
            guardarCordenadas(intentosCpu);
            return comprobarFin(intentosCpu, intentos);
        }
        public Boolean TurnoJugador(ArrayList intentos, ArrayList intentosCpu)
        {
            ConsoleKey tecla = new ConsoleKey();
            pintarBorde(minX, minY, 10);
            Console.SetCursorPosition(minX, minY);
            int posX = Console.CursorLeft;
            int posY = Console.CursorTop;
            pintarIntentos(intentos, intentosCpu);
            do
            {
                Console.SetCursorPosition(posX, posY);
                tecla = Console.ReadKey(true).Key;
                switch (tecla)
                {
                    case ConsoleKey.LeftArrow:
                        if (posX > minX)
                        {
                            posX--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (posX < maxX)
                        {
                            posX++;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (posY < maxY)
                        {
                            posY++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (posY > minY)
                        {
                            posY--;
                        }
                        break;
                }
            } while (tecla != ConsoleKey.Enter);
            guardarCordenadas(intentos);
            return comprobarFin(intentos,intentosCpu);
        }
        public void guardarCordenadas(ArrayList intentos)
        {
            Boolean existe = false;
            for (int i = 1; i < intentos.Count; i++)
            {
                if (((cordenadas)intentos[i]).compCordenadas(new cordenadas(Console.CursorLeft, Console.CursorTop)))
                {
                    existe = true;
                    i = intentos.Count;
                }
            }
            if (!existe)
            {
                intentos.Add(new cordenadas(Console.CursorLeft, Console.CursorTop));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Boolean fin = false;
            Juego juego = new Juego(12,10,3,1,15);
            ArrayList intentos = new ArrayList();
            ArrayList intentosCpu = new ArrayList();
            Console.WriteLine("Selecciona la posiocion de tu barco");
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Selecciona la posicion que quieras atacar");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Campo Jugador");
            Console.SetCursorPosition(15, 1);
            Console.WriteLine("Campo CPU");
            do
            {
                if (!juego.TurnoJugador(intentos, intentosCpu))
                {
                    if(juego.turnoCpu(intentosCpu, intentos))
                    {
                        fin = true;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Has perdico");
                        Console.ReadKey();
                    }
                }
                else
                {
                    fin = true;
                    Console.Clear();
                    Console.SetCursorPosition(10, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Has ganado");
                    Console.ReadKey();
                }
            } while (!fin);
        }
    }
}
