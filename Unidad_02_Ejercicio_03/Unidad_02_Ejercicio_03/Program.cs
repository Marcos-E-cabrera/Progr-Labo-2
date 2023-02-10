/*
                                    Ejercicio I03 - Conversor binario
    Consigna
    Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

    El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

    public string ConvertirDecimalABinario(int numeroEntero) {}

    El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

    public int ConvertirBinarioADecimal(int numeroEntero) {}

    IMPORTANTE
    NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.
 */

namespace Unidad_02_Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binario;
            int num;

            // pido numero
            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            binario = Conversor.ConvertirDecimalABinario(numero);
            Console.WriteLine("El numero binaraio es: "+binario);

            Console.Write("Ingrese un número binario: ");
            string  numBinario= Console.ReadLine();

            num = Conversor.ConvertirBinarioADecimal(numBinario);
            Console.WriteLine("El numero Decimal es: " + num);

        }

        public static class Conversor
        {
            /// <summary>
            /// Convierte un número entero del sistema decimal al sistema binario.
            /// </summary>
            /// <param name="numeroEntero">El número decimal a convertir.</param>
            /// <returns>El número binario resultante de la conversión.</returns>         
            public static string ConvertirDecimalABinario(int numeroEntero)
            {
                string binario = "";
                int resto;

                while (numeroEntero > 0)
                {
                    // El "resto" puede ser 0 o 1, dependiendo de si "numeroEntero" es par o impar.
                    resto = numeroEntero % 2;
                    // El resto se agrega al inicio de la cadena "binario". De esta manera, se construye
                    // la representación binaria del número entero de forma ordenada,
                    // empezando por el último dígito y terminando con el primer dígito.
                    binario = resto + binario;
                    // divide "numeroEntero" por 2 y lo devulve a la misma variable.
                    numeroEntero = numeroEntero / 2;
                }
                return binario;
            }

            /// <summary>
            /// Convierte un número entero del sistema binario al sistema decimal.
            /// </summary>
            /// <param name="numeroBinario">El número binario a convertir.</param>
            /// <returns>El número decimal resultante de la conversión.</returns>
            public static int ConvertirBinarioADecimal(string numeroBinario)
            {
                int decimalResultante = 0;
                int potencia = 1;

                // Recorre el número binario de derecha a izquierda
                for (int i = numeroBinario.Length - 1; i >= 0; i--)
                {
                    // Si el dígito es '1', agrega su peso a la suma decimal
                    if (numeroBinario[i] == '1')
                    {
                        decimalResultante += potencia;
                    }

                    // Multiplica la potencia por 2 para el siguiente ciclo
                    potencia *= 2;
                   
                }

                return decimalResultante;
            }


        }
    }
}