using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local : Llamada
    {
        // Campos
        protected float costo;

        // Propiedad
        public float CostoLlamada { get; }

        // Metodos
        private float CalcularCosto()
        {
            return 0;
        }

        //public Local ( Llamada llamada , float costo) 
        //{
        //    this.costo = costo;
        //}

        public Local ( string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public string Mostrar()
        {
            return "";
        }


    }
}
