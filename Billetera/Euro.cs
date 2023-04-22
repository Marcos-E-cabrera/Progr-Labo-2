namespace Billetera
{
    public class Euro
    {
        #region Campos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Cosntrucores
        static Euro()
        {
            cotizRespectoDolar = 1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region Sobrecarga de Operadores de Convercion Explicita / Implicita

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() * Dolar.GetCotizacion());
        }

        public static explicit operator Peso(Euro e)
        {
            double cantidadEnDolares = e.GetCantidad() * Euro.GetCotizacion();
            return new Peso(cantidadEnDolares * Peso.GetCotizacion());
        }

        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }
        #endregion



    }
}