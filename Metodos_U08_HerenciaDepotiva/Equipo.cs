using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U08_HerenciaDepotiva
{
    public class Equipo
    {
        // campos
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        // constructor
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidad;
        }

        public string Nombre { get { return nombre;  } }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (!e.jugadores.Contains(j) && e.jugadores.Count < e.cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                return true;
            }
            return false;
        }

    }
}
