/*                                                  
 *                                                  Ejercicio I01 - Validador de rangos
    Consigna: 
    Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

       bool Validar(int valor, int min, int max)

    valor: dato a validar.
    min: mínimo valor incluido.
    max: máximo valor incluido.
    
    Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
    Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

    IMPORTANTE:
    Utilizar variables escalares, NO utilizar vectores/arrays.
 
 */


namespace Unidad_02_Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorMin = int.MaxValue;
            int valorMax = int.MinValue;
            int suma = 0;
            int contador = 0;

            for (int i = 1; i <= 10; i++)
            {
                // bloque Pedir numero
                Console.Write("Ingrese un número entero: ");
                int valor = int.Parse(Console.ReadLine());

                // validar numero
                if (Validador.Validar(valor, -100, 100))
                {
                    suma += valor;
                    contador++;
                    if (valor < valorMin)
                    {
                        valorMin = valor;
                    }
                    if (valor > valorMax)
                    {
                        valorMax = valor;
                    }
                }
                else
                {
                    Console.WriteLine("El número ingresado no es válido.");
                    i--;
                }
            }

            if (contador > 0)
            {
                Console.WriteLine("Valor mínimo: " + valorMin);
                Console.WriteLine("Valor máximo: " + valorMax);
                Console.WriteLine("Promedio: " + (suma / contador));
            }
            else
            {
                Console.WriteLine("No se ingresaron números válidos.");
            }
        }

        public static class Validador
        {
            public static bool Validar(int valor, int min, int max)
            {
                return valor >= min && valor <= max;
            }
        }

    }

}