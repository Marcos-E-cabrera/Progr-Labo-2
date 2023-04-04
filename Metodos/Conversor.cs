using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class Conversor
    {
        /// <summary>
        /// Convierte un número entero del sistema decimal al sistema binario.
        /// </summary>
        /// <param name="numeroEntero">numero en decimal.</param>
        /// <returns>El número binario resultante de la conversión.</returns>         
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string binario = "";

            do
            {     
                /*
                10 % 2 = 0
                10/2
                5 % 2 = 1
                5/2
                2 % 2 = 0
                2/2
                1 % 2 = 1
                1/2

                10(d) = 1010(b)
                */
                binario = (numeroEntero % 2).ToString() + binario;
                numeroEntero /= 2;
            } while (numeroEntero != 0);

            return binario;
        }

        /// <summary>
        /// Convierte un número entero del sistema binario al sistema decimal.
        /// </summary>
        /// <param name="numeroBinario">numero binario.</param>
        /// <returns>El número decimal resultante de la conversión.</returns>
        public static int ConvertirBinarioADecimal(string numeroBinario)
        {
            // metodo peso
            //  1     0     1     0
            //  8     4     2     1  : POTENCIA DE 2
            // 2^3   2^2   2^1   2^0

            double numeroDecimal = 0;
            int len;

            len = numeroBinario.Length - 1;
            for (int i =  len; i >= 0; i--)
            {
                if (numeroBinario[i] == '1')
                {
                    numeroDecimal += Math.Pow(2, len - i);
                }
            }

            return (int)numeroDecimal;
        }
    }
}
