// https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/objetos/Ejercicios/I04-invento-argentino/
using Metodos_clase02;

namespace Unidad_03_Ejercicio_i04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujo;

            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);

            Console.WriteLine($"El bolígrafo azul tiene {boligrafoAzul.GetTinta()} unidades de tinta");
            Console.WriteLine($"El bolígrafo rojo tiene {boligrafoRojo.GetTinta()} unidades de tinta");

            Console.WriteLine("Pintando con el bolígrafo azul:");
            boligrafoAzul.Pintar(20, out dibujo);

            Console.WriteLine("\nPintando con el bolígrafo rojo:");
            boligrafoRojo.Pintar(60, out dibujo);

            Console.WriteLine($"\nEl bolígrafo azul tiene {boligrafoAzul.GetTinta()} unidades de tinta");
            Console.WriteLine($"El bolígrafo rojo tiene {boligrafoRojo.GetTinta()} unidades de tinta.");

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Pintando con el bolígrafo azul:");
            boligrafoAzul.Pintar(20, out dibujo);

            Console.WriteLine("\nPintando con el bolígrafo rojo:");
            boligrafoRojo.Pintar(60, out dibujo);

            Console.WriteLine($"\nEl bolígrafo azul tiene {boligrafoAzul.GetTinta()} unidades de tinta");
            Console.WriteLine($"El bolígrafo rojo tiene {boligrafoRojo.GetTinta()} unidades de tinta.");

            boligrafoRojo.Recargar();
            Console.WriteLine($"Recargando el bolígrafo Rojo. Ahora tiene {boligrafoRojo.GetTinta()} unidades de tinta.");

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Pintando con el bolígrafo azul:");
            boligrafoAzul.Pintar(40, out dibujo);

            Console.WriteLine("\nPintando con el bolígrafo rojo:");
            boligrafoRojo.Pintar(30, out dibujo);

            Console.WriteLine($"\nEl bolígrafo azul tiene {boligrafoAzul.GetTinta()} unidades de tinta");
            Console.WriteLine($"El bolígrafo rojo tiene {boligrafoRojo.GetTinta()} unidades de tinta.");

            
            Console.ReadLine();

        }
    }
}