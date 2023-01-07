/*
    Ejercicio I01 - Máximo, mínimo y promedio
    
    CONSIGNA:
    Ingresar 5 números por consola, guardándolos en una variable escalar. 
    Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

    INFORMACIÓN: 
    Un escalar es una constante o variable que contiene un dato atómico y unidimensional. 
    En contraposición al concepto de escalar, están los conceptos de array, lista y objeto, 
    que pueden tener almacenado en su estructura más de un valor    
*/

namespace Unidad_01_Introduccion_Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  ANKI :
                Variable escalar = unidimensional, array
                array.Length =  Gets the total number of elements in all the dimensions of the Array.
                Console.ReadLine() devuelve string y por eso lo PARSEO int.
            */

            // creamos un array de enteros
            int[] numeros = new int[5];
            int maximo = 0;
            int minimo = 0;
            float promedio;
            int acumulador = 0;

           
            for ( int i = 0; i < numeros.Length; i++ )
            {
                Console.Write("Ingrese un numero: ");
                numeros[i] = int.Parse(Console.ReadLine()); // Console.ReadLine() devuelve string y por eso lo PARSEO int.

                acumulador += numeros[i];

                if ( i == 0 || numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }
                if (i == 0 || numeros[i] < minimo)
                {
                    minimo = numeros[i];
                }

            }

            promedio = (float)acumulador / numeros.Length;

            Console.Write("El valor Maximo {0}, El valor minimo {1} y El promedio {2}",maximo,minimo,promedio);
        }
    }
}