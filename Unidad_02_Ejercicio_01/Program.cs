/*
    Ejercicio I01 - Validador de rangos
    Consigna
    Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
    
    bool Validar(int valor, int min, int max)

    valor: dato a validar.
    min: mínimo valor incluido.
    max: máximo valor incluido.
    Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

    Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

    IMPORTANTE
    Utilizar variables escalares, NO utilizar vectores/arrays.
 */

using Metodos;

namespace Unidad_02_Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int min;
            int max;
            int acumulador;

            acumulador = 0;
            min = 0;
            max = 0;

            float promedio;
            int cantidadNumero;

            cantidadNumero = 5;

            for ( int i = 0; i < cantidadNumero; i++ ) 
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                while ( (Validador.Validar(numero,-100,100)) != true )
                {
                    Console.Write("Reingrese un numero: ");
                    numero = int.Parse(Console.ReadLine());
                }

                if ( numero > max)
                {
                    max = numero;   
                }

                if( numero < min)
                {
                    min = numero;
                }

                acumulador += numero;
            }

            promedio = acumulador / cantidadNumero;


            Console.WriteLine($"Maximo: {max} - Minimo: {min} - Promedio: {promedio}");
        }
    }
}