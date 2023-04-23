using System.Text;

namespace Metodos_U08_CentralTelefonica
{
    public class Llamada
    {
        // Campos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        // Propiedades
        public float Duracion { get { return duracion; } }
        public string NroDestino { get { return nroDestino; } }
        public string NroOrigen { get { return nroOrigen; } }

        // Metodos
        public Llamada ( float duracion, string nroDestino, string nroOrigen )
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder datosLlamada= new ();
            datosLlamada.AppendLine("--------------------------");
            datosLlamada.AppendLine($"Duracion: {Duracion}");
            datosLlamada.AppendLine($"Nro. Origen: {NroOrigen}");
            datosLlamada.AppendLine($"Nro. Destino: {NroDestino}");
            datosLlamada.AppendLine("--------------------------");

            return datosLlamada.ToString();
        }

        /// <summary>
        /// Centralita I:
        /// Ordena por duracion de la llamada
        /// </summary>
        /// <returns> Si da Negativo ( l2 > l1), si da Positivo ( l1 > l2 ) y si da 0 ( l1 == l2 ) </returns>
        public static int OrdenarPorDuracion ( Llamada l1, Llamada l2)
        {
            return (int) (l1.Duracion - l2.Duracion);
        }

    }
}