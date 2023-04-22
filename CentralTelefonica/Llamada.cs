namespace CentralTelefonica
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
        public string NroOrigen { get { return NroOrigen; } }

        // Metodos
        public Llamada ( float duracion, string nroDestino, string nroOrigen )
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            return "";
        }

        public int OrdenarPorDuracion ( Llamada l1, Llamada l2)
        {   
            return 0;
        }

    }
}