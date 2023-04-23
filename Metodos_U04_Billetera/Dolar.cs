using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U04_Billetera
{
    public class Dolar
    {
        #region Campos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Cosntrucores
        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region Sobrecarga de Operadores de Convercion Explicita / Implicita

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.GetCantidad() * Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.GetCantidad() * Peso.GetCotizacion());
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
       
        #region Sobrecarga de Booleanos
        public static bool operator == (Dolar d, Euro e)
        {
            return (d.cantidad == e.GetCantidad());
        }

        public static bool operator != (Dolar d, Euro e)
        {
            return (d.cantidad != e.GetCantidad());
        }

        public static bool operator ==(Dolar d, Peso e)
        {
            return (d.cantidad == e.GetCantidad());
        }

        public static bool operator !=(Dolar d, Peso e)
        {
            return (d.cantidad != e.GetCantidad());
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.cantidad == d2.cantidad);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return (d1.cantidad != d2.cantidad);
        }
        #endregion

        #region Sobrecarga Operadores +/-
        public static Dolar operator - (Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad() * Euro.GetCotizacion());
        }
        public static Dolar operator - (Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad() / Peso.GetCotizacion());
        }

        public static Dolar operator + (Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad() * Euro.GetCotizacion());
        }
        public static Dolar operator + (Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad() / Peso.GetCotizacion());
        }
        #endregion


        #endregion

    }
}
