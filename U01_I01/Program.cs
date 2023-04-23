/*
                                            Ejercicio I01 - Máximo, mínimo y promedio
Consigna:
            Ingresar 5 números por consola, guardándolos en una variable escalar. 
            Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
 */

namespace U01_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
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