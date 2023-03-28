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

using System;

namespace Unidad_01_Introduccion_Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  ANKI :
            //    Variable escalar = unidimensional, array
            //    array.Length =  Gets the total number of elements in all the dimensions of the Array.
            //    Console.ReadLine() devuelve string y por eso lo PARSEO int.
            */

            int numero;
            int valorMaximo = int.MinValue;
            int valorMinimo = int.MaxValue;

            int acumulador = 0;
            float promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                Maximo_Minimo(numero, ref valorMaximo, ref valorMinimo);

                acumulador += numero;

            }

            promedio = acumulador / 5;

            Console.WriteLine($"El valor maximo es {valorMaximo}");
            Console.WriteLine($"El valor minimo es {valorMinimo}");
            Console.WriteLine($"El promedio es {promedio}");

        }

        public static void Maximo_Minimo(int num, ref int valorMaximo, ref int valorMinimo)
        {
            if (num > valorMaximo)
            {
                valorMaximo = num;
            }
            if (num < valorMinimo)
            {
                valorMinimo = num;
            }
        }


    }
}