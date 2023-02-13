/*
                        Ejercicio A01 - Calcular un factorial
    Consigna
    El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los 
    números enteros positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de 
    multiplicar 3 por 2 por 1.

    En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.
 
 */

namespace Unidad_02_Ejercicio_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Ingrese un numero entero positivo: ");
            int numero = int.Parse(Console.ReadLine());
          
            Console.WriteLine($"El Factorial de {numero} es: {Factorial(numero)}");
        }


        public static int Factorial(int numero)
        {
            int factorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}