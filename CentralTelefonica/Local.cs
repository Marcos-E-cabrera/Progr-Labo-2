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
        public float CostoLlamada { get { return CalcularCosto(); } }

        // Metodos
        /// <summary>
        /// Calcula el costo de la llama .
        /// </summary>
        /// <returns> Retornará el valor de la llamada a partir de la duración y el costo de la misma. </returns>
        private float CalcularCosto()
        {
            return (float) duracion * costo;
        }

        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        

        public new string Mostrar()
        {
            StringBuilder datosLlamada = new();
            datosLlamada.AppendLine("--------------------------");
            datosLlamada.AppendLine("Tipo de Local:");
            datosLlamada.AppendLine(base.Mostrar());
            datosLlamada.AppendLine($"Costo Por Minuto: {costo}");
            datosLlamada.AppendLine($"Costo de llamada: {CostoLlamada}");
            datosLlamada.AppendLine("--------------------------");

            return datosLlamada.ToString();
        }


    }
}
