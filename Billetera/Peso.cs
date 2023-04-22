using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera
{
    public class Peso
    {
        #region Campos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Cosntrucores
        static Peso()
        {
            cotizRespectoDolar = 102.65;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters
        public static double GetCotizacion()
        {
            return Peso.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region Sobrecarga de Operadores de Convercion Explicita / Implicita
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.GetCantidad() / Peso.GetCotizacion());
        }

        public static explicit operator Euro(Peso p)
        {
            double cantidadEnDolares = p.GetCantidad() / Peso.GetCotizacion();
            return new Euro(cantidadEnDolares / Euro.GetCotizacion());
        }

        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }
        #endregion

    }
}
