/*
    Ejercicio I04 - Un número perfecto
    
    CONSIGNA:
    Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo)
    que son divisores del número.
    
    El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
    
    Escribir una aplicación que encuentre los 4 primeros números perfectos.

    IMPORTANTE:
    Utilizar sentencias de iteración y selectivas.
 
 */

namespace Unidad_01_Introduccion_Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int i = 2;

            Console.Write("Los primeros cuatro numeros \"PERFECTOS\" son: ");
            Console.WriteLine("\n\n\"NUMEROS PERFECTOS\"");

            while (contador != 4) //los primeros 4 numeros
            {
               int numeroPerfecto = 0; // numero perfecto

                for (int j = 1; j < i; j++) // inicia en un numero positivo
                {
                    if ( i % j == 0 ) // veo si el numero primo
                    {
                        numeroPerfecto += j;
                    }
                }

                //SI i coincide con el numero perfecto:
                if (i == numeroPerfecto)
                {
                    //tiene que imprimir 6,28,496 y 8128
                    Console.WriteLine(i);
                    contador++;
                }

                i++;
            }

           Console.WriteLine("\n( ! ) PRESIONE UNA TECLA PARA FINALIZAR EL PROGRAMA.");
           Console.ReadKey(); // espera que toques un tecla
        }
    }
}