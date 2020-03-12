using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Tema3
{
    public enum Estilo
    {
        Arcade,
        Videoaventura,
        Shootemup,
        Estrategia,
        Deportivo
    }
    struct juego
    {
        public String titulo;
        public int año;
        public Estilo estilo;

        public juego(String titulo, int año, Estilo estilo)
        {
            this.titulo = titulo;
            this.año = año;
            this.estilo = estilo;
        }


    }
}
