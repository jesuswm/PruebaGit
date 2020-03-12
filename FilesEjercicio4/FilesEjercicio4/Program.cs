using System;
using System.IO;

namespace FilesEjercicio4
{
    class BinWriterJuego : BinaryWriter
    {
        public BinWriterJuego(Stream output) : base(output)
        {
        }
        public void Write(juego j)
        {
            Write(j.titulo);
            Write(j.año);
            Write((int)j.estilo);
        }
    }
    class BinReaderJuego : BinaryReader
    {
        public BinReaderJuego(Stream str) : base(str)
        {
        }
        public juego ReadJuego() 
        {
            try
            {
                juego j = new juego(base.ReadString(), base.ReadInt32(), (Estilo)base.ReadInt32());
                return j;
            }
            catch (System.IO.EndOfStreamException)
            {
                throw;
            }
            
        }
    }

    class Program
    {
        static int PedirInt(String error)
        {
            int a = 0;
            bool valido = true;
            do
            {
                valido = true;
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(error);
                    valido = false;
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine("El valor introducido debe de estar entre -2.147.483.648 y 2.147.483.647");
                    valido = false;
                }
            } while (!valido);
            return a;
        }
        static Estilo pedirEstilo()
        {
            int indicador = 1;
            int contador = -1;
            Estilo estilo;
            do
            {
                indicador = 1;
                contador = -1;
                Console.WriteLine("Selecciona el estilo");
                foreach (int i in Enum.GetValues(typeof(Estilo)))
                {
                    Console.WriteLine(indicador + "- " + (Estilo)i);
                    contador++;
                    indicador++;
                }
                estilo = (Estilo)(PedirInt("No se ha introducido un numero") - 1);
            } while ((int)estilo < 0 || (int)estilo > contador);
            return (Estilo)estilo;
        }
        static void Main(string[] args)
        {

            bool salir = false;
            int select;
            const String errorNumero = "No se ha introducido un numero";
            Estilo estilo;
            Videojuegos operaciones = new Videojuegos();
            try
            {
              //  using (Program p = new Program()) { }
                using (BinReaderJuego leer = new BinReaderJuego(new FileStream(Environment.GetEnvironmentVariable("USERPROFILE") + "\\DatosEj4.dat", FileMode.Open)))
                {
                    int numero = leer.ReadInt32();
                    try
                    {
                        for (int j = 0; j < numero; j++)
                        {
                            operaciones.juegos.Add(leer.ReadJuego());
                        }

                    }
                    catch (System.IO.EndOfStreamException) { }
                    finally
                    {
                        leer.Dispose();
                    }
                }
            }
            catch (System.IO.FileNotFoundException) { }
#if prueba
            operaciones.juegos.Add(new juego("1", 1, Estilo.Arcade));
            operaciones.juegos.Add(new juego("2", 2, Estilo.Deportivo));
            operaciones.juegos.Add(new juego("3", 3, Estilo.Estrategia));
#endif
            do
            {
                String nombre;
                int año;
                Console.WriteLine("Menu");
                Console.WriteLine("1.-Insertar nuevo videojuego.");
                Console.WriteLine("2.-Eliminar videojuegos");
                Console.WriteLine("3.-Visualizar toda las lista de videojuegos");
                Console.WriteLine("4.-Visualización de videojuegos de un estilo determinado");
                Console.WriteLine("5.-Modificación de un videojuego ");
                Console.WriteLine("6.-Salir");
                //Console.WriteLine("Tamaño lista:{0}",juegos.Count);
                try
                {
                    select = PedirInt(errorNumero);
                    switch (select)
                    {
                        case 1:
                            Console.WriteLine("Introduce el nombre del juego");
                            nombre = Console.ReadLine().Trim();
                            do
                            {
                                Console.WriteLine("Introduce el año del juego");
                                año = PedirInt(errorNumero);
                                if (año < 0)
                                {
                                    Console.WriteLine("El año tiene que ser mayor que 0");
                                }
                            } while (año < 0);
                            estilo = pedirEstilo();
                            operaciones.juegos.Insert(operaciones.PosicionInser(año), new juego(nombre, año, estilo));
                            break;
                        case 2:
                            if (operaciones.juegos.Count > 0)
                            {

                                int inicio;
                                Console.WriteLine("Desde que indice deseas borrar");
                                inicio = PedirInt(errorNumero);
                                int fin;
                                Console.WriteLine("Hasta que indice deseas borrar");
                                fin = PedirInt(errorNumero);
                                if (operaciones.Eliminar(fin, inicio))
                                {
                                    Console.WriteLine("Operacion realizada con exito");
                                }
                                else
                                {
                                    Console.WriteLine("No se pudo terminar la operación");
                                }
                            }
                            else
                            {
                                Console.WriteLine("La lista esta vacia");
                            }
                            break;
                        case 3:
                            if (operaciones.juegos.Count != 0)
                            {
                                string titulo;
                                for (int i = 0; i < operaciones.juegos.Count; i++)
                                {
                                    if (((juego)operaciones.juegos[i]).titulo.Length <= 5)
                                    {
                                        titulo = ((juego)operaciones.juegos[i]).titulo;
                                    }
                                    else
                                    {
                                        titulo = ((juego)operaciones.juegos[i]).titulo.Substring(0, 4) + "...";
                                    }
                                    Console.WriteLine("{0}.- Titulo: {1,10},Año: {2},Genero: {3}", i + 1, titulo, ((juego)operaciones.juegos[i]).año, ((juego)operaciones.juegos[i]).estilo);
                                }
                            }
                            else
                            {
                                Console.WriteLine("La lista esta vacia");
                            }
                            break;
                        case 4:
                            estilo = pedirEstilo();
                            foreach (juego a in operaciones.Busqueda(estilo))
                            {
                                Console.WriteLine("Titulo: {0},Año: {1},Genero: {2}", a.titulo, a.año, a.estilo);
                            }
                            break;
                        case 5:
                            int indice;
                            Console.WriteLine("Que juego quieres modificar");
                            indice = PedirInt(errorNumero);
                            Console.WriteLine("Introduce el nombre del juego");
                            nombre = Console.ReadLine().Trim();
                            estilo = pedirEstilo();
                            operaciones.modificar(indice, nombre, estilo);
                            break;
                        case 6:
                            salir = true;
                            break;
                    }
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("No se ha introducido un valor numerico se regresara al menu inicial");
                }
                catch (System.IndexOutOfRangeException e)
                {
                    Console.WriteLine("No existe un juego con ese indice");
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine("El valor introducido debe de estar entre -2.147.483.648 y 2.147.483.647");
                }
            } while (!salir);
            BinWriterJuego escribir = new BinWriterJuego(new FileStream(Environment.GetEnvironmentVariable("USERPROFILE") +"\\DatosEj4.dat", FileMode.Create));
            escribir.Write(operaciones.juegos.Count);
            foreach (juego jue in operaciones.juegos)
            {
                //Console.WriteLine(jue.titulo);
                    escribir.Write(jue);
            }
            escribir.Dispose();
        }
    }
    }
