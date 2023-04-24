namespace Metodos_U08
{
    public class Automovil : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int cantidadPasajeros;

        public short CantidadMarchas { get; set; }
        public int CantidadPasajeros { get; set; }

        public Automovil(short cantidadRuedas, short cantidadPuertas, eColores eColor, short cantidadMarchas, int cantidadPasajeros)
            : base ( cantidadRuedas, cantidadPuertas, eColor)
        {
            this.CantidadMarchas = cantidadMarchas;
            this.CantidadPasajeros = cantidadPasajeros;
        }
    }
}