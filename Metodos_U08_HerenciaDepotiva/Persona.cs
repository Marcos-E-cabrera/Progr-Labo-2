using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U08_HerenciaDepotiva
{
    public class Persona
    {
        // Campos
        private long dni;
        private string nombre;

        // Propiedades
        public long Dni { get { return dni; } set { dni = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }

        // Metodos  
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }        

        public Persona(string nombre, long dni) : this(nombre)
        {
            this.nombre = nombre;
        }

        public string MostrarDatos()
        {
            return $"Dni: {Dni}\nNombre: {Nombre}\n";
        }

    }
}
