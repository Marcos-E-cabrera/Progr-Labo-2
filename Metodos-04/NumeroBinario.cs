using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_04
{
    public class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string GetBinario()
        {
            return numero; 
        }

        // Conversión implícita de string a NumeroBinario
        public static implicit operator NumeroBinario(string n)
        {
            return new NumeroBinario(n);
        }

        // Conversión explícita de NumeroBinario a string
        public static explicit operator string(NumeroBinario n)
        {
            return n.numero;
        }

        public static bool operator == (NumeroBinario nB, NumeroDecimal nD)
        {
            return ( nB.numero == nD.GetDecimal());
        }

    }
}
