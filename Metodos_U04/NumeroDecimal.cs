using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U04
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double GetDecimal()
        {
            return numero;
        }

        public static implicit operator NumeroDecimal(double n)
        {
            return new NumeroDecimal(n);
        }

        // Conversión explícita de NumeroDecimal a double
        public static explicit operator double (NumeroDecimal n)
        {
            return n.numero;
        }

        
    }
}
