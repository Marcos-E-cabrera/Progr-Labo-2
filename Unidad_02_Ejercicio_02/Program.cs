/*
     Ejercicio I02 - ¿Desea continuar?
    onsigna
    Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

    Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

    El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 */

using Metodos;
using System.Security.Cryptography;

namespace Unidad_02_Ejercicio_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador;
            string? respuesta;

            acumulador  = 0;

            do
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                acumulador += acumulador;

                Console.Write("¿Desea continuar ? (S / N): ");
                respuesta = Console.ReadLine();

            } while ( Validador.ValidarRespuesta(respuesta) );

            Console.WriteLine($"acumulador: {acumulador}");
        }
    }
}