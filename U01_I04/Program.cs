/*
                                        Ejercicio I04 - Un número perfecto
    
CONSIGNA:
            Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo)
            que son divisores del número.
    
            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
    
            Escribir una aplicación que encuentre los 4 primeros números perfectos.
            
            IMPORTANTE: Utilizar sentencias de iteración y selectivas.
 
 */

namespace U01_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            int i = 2;

            Console.WriteLine("Los primeros cuatro numeros PERFECTOS:");

            // - INICIO - NUMERO PERFECCTO
            while (contador != 4) // los primeros 4 numeros
            {
                int numeroPerfecto = 0; // numero perfecto

                for (int j = 1; j < i; j++) // inicia en un numero positivo
                {
                    if (IsNumeroPrimo(i, j))
                    {
                        numeroPerfecto += j;
                    }
                }

                //SI "i" coincide con el numero perfecto:
                if (i == numeroPerfecto)
                {
                    Console.WriteLine(i);
                    contador++;
                }

                i++;
            }

        }

        internal static bool IsNumeroPrimo(int x, int y)
        {
            return x % y == 0;
        }
    }
}