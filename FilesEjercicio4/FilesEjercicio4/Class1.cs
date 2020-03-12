using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace FilesEjercicio4
{
    public class Videojuegos
    {
        public ArrayList juegos = new ArrayList(); //List<juegos>
        public int PosicionInser(int año)
        {
            int inser = juegos.Count;
            for (int i = juegos.Count - 1; i >= 0; i--)
            {
                if (((juego)juegos[i]).año <= año)
                {
                    inser = i + 1;
                    i = -1;
                }
            }
            return inser;
        }
        public bool Eliminar(int max, int? min = 0)
        {
            if ((min >= 0 && min < juegos.Count) && (max >= 0 && max < juegos.Count) && max >= min)
            {
                for (int i = max; i >= min; i--)
                {
                    juegos.RemoveAt(i);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public ArrayList Busqueda(Estilo estilo)
        {
            ArrayList listaPorEstilo = new ArrayList();
            for (int i = 0; i < juegos.Count; i++)  //foreach
            {
                if (((juego)juegos[i]).estilo == estilo)
                {
                    listaPorEstilo.Add(juegos[i]);
                }
            }
            return listaPorEstilo;
        }
        public void modificar(int indice, string titulo, Estilo estilo)
        {
            if (indice >= 0 && indice < juegos.Count)
            {
                juegos[indice] = new juego(titulo, ((juego)juegos[indice]).año, estilo);
            }
            else
            {
                Console.WriteLine("No existe un juego con ese indice");
            }
        }
    }
}
