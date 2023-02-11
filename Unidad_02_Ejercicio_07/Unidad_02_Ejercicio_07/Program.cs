/*
                Ejercicio I07 - Pitágoras estaría orgulloso
    Consigna
    Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en 
    centímetros.

    El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y
    Usar     los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

    Mostrar el resultado en la consola.
 */

namespace Unidad_02_Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de longitud de hipotenusa");
            Console.WriteLine("Ingrese la base del triángulo en centímetros:");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triángulo en centímetros:");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            double hipotenusa = CalcularHipotenusa(baseTriangulo, alturaTriangulo);

            Console.WriteLine($"La longitud de la hipotenusa es de {hipotenusa:0.##} centímetros");
        }

        static double CalcularHipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            return Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
        }
    }
}