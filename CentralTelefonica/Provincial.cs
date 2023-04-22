using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Provincial : Llamada
    {
        // campos
        private Franja franjaHoraria;

        // Propiedades
        public float CostoLlamada { get; }

        // Metodos
        private float CostoLlamada()
        {
            return 0;
        }

        public Provincial (Franja miFranja, Llamada llamada)
        {
            
        }

        public Provincial ( string origen, Franja miFranja, float duracion,string destino ) : base ( duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public string Mostrar()
        {
            return "";
        }


    }
}
