/*
                                        Ejercicio I02 - Error al cubo
Consigna:
                Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero,
                caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

                IMPORTANTE: Utilizar el método Pow de la clase Math para calcular las potencias.
 */
namespace U01_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int cuadrado;
            int cubo;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (numero < 1)
            {
                Console.Write("ERROR. ¡Reingresar número!: ");
                numero = int.Parse(Console.ReadLine());
            }

            cuadrado = (int)Math.Pow(numero, 2); //Se debe de castear math.pow porque devuelve un double
            cubo = (int)Math.Pow(numero, 3);

            Console.WriteLine($"Numero: {numero} - Cubo: {cubo} - Cuadrado: {cuadrado}");
        }
    }
}