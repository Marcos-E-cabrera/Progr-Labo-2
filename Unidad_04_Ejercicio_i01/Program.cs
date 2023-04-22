// https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/sobrecarga/Ejercicios/I01-sumador/
using Metodos_04;

namespace Unidad_04_Ejercicio_i01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long resultadoLong;
            string resultadoString;

            Sumador sumador1 = new Sumador();
            Console.WriteLine($"Cantidad de sumas: {(int)sumador1}");

            resultadoLong = sumador1.Sumar(2, 2);
            Console.WriteLine($"Resultado Long: {resultadoLong}");
            Console.WriteLine($"Cantidad de sumas: {(int)sumador1}");

            resultadoString = sumador1.Sumar("Helo,", "World!");
            Console.WriteLine($"Resultado Long: {resultadoString}");
            Console.WriteLine($"Cantidad de sumas: {(int)sumador1}");

            // ----
            Console.WriteLine("\n\n");
            // ----

            Sumador sumador2 = new Sumador();
            resultadoLong = sumador2.Sumar(6, 2);
            Console.WriteLine($"Resultado Long: {resultadoLong}");
            Console.WriteLine($"Cantidad de sumas: {(int)sumador2}");

            Console.WriteLine($"Suma de Sumadores: {sumador1 + sumador2}");
            Console.WriteLine($"Tienen la misma cantidad de sumadores?: {sumador1 | sumador2}");
        }
    }
}

