/*
                    Ejercicio I06 - Calculadora de áreas
    Consigna
    Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) 
    que realicen el cálculo del área que corresponda:

    public double CalcularAreaCuadrado(double longitudLado) {}

    public double CalcularAreaTriangulo(double base, double altura) {}

    public double CalcularAreaCirculo(double radio) {}

    El ingreso de los datos como la visualización se deberán realizar desde el método Main().
 */

namespace Unidad_02_Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese La longitud de Cuadrado: ");
            double longitud = double.Parse(Console.ReadLine());

            Console.WriteLine($"El Area del cuadrado es: " + CalculadoraDeArea.CalcularAreaCuadrado(longitud));
               
            Console.Write("Ingrese La base del Triangulo: ");
            double @base = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la Altura del Triangulo: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("El Area del Triangulo es: " + CalculadoraDeArea.CalcularAreaTriangulo(@base, altura));

            Console.Write("Ingrese el Radio del Cirulo: ");
            double radio = double.Parse(Console.ReadLine());

            Console.WriteLine("El Area del Circulo es: " + CalculadoraDeArea.CalcularAreaCirculo(radio));

        }
    }

    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            return (longitudLado * longitudLado);
        }

        public static double CalcularAreaTriangulo(double @base, double altura) 
        {
            return (@base * altura) / 2;
        }

        public static double CalcularAreaCirculo(double radio) 
        {
            return (Math.PI * radio * radio);
        }
    }
}