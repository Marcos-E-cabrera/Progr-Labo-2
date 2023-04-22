/*
                                                        Ejercicio I01 - Números locos
Consigna:
            Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) 
            distintos de cero de forma aleatoria utilizando la clase Random.

            1. Mostrar el vector tal como fue ingresado.
            2. Luego mostrar los positivos ordenados en forma decreciente.
            3. Por último, mostrar los negativos ordenados en forma creciente.
 
 */

using System.Numerics;

namespace Unidad_06_Ejercicio_i01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] vector = new int[20];

            int len = vector.Length;

            for (int num = 0; num < len - 1; num++)
            {
                int numero = random.Next(-100, 100);
                if (vector[num] == 0)
                {
                   vector[num] = numero;
                }
            }
            ImprimirVector(vector);

            Console.WriteLine("\n\nlos positivos ordenados en forma decreciente:");

            for (int i = 0; i <= len - 1; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (vector[i] < vector[j])
                    {
                        int temp = vector[i];
                        vector[i] = vector[j];
                        vector[j] = temp;
                    }
                }
            }
            ImprimirVector(vector);

            Console.WriteLine("\n\nlos negativos ordenados en forma creciente:");

            for (int i = 0; i <= len - 1; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        int temp = vector[i];
                        vector[i] = vector[j];
                        vector[j] = temp;
                    }
                }
            }
            ImprimirVector(vector);
        }
        static void ImprimirVector(int[] vector)
        {
            for ( int i = 0; i < vector.Length; i++ ) 
            {
                Console.Write($" {vector[i]}");
            }
            Console.WriteLine();
        }
    }
}