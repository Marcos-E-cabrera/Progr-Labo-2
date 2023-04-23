/*                                      Ejercicio I04 - La calculadora
Consigna:
            Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

            Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

            Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática.
            El método devolverá el resultado de la operación.

            Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

            Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

            El usuario decidirá cuándo finalizar el programa.
 */
using Metodos_U02;

namespace U02_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resultado;

            string? signo;
            string? respuesta;

            do
            {

                Console.Write("Ingrese un numero: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese un numero: ");
                num2 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese un operador ( +, -, *, / ): ");
                signo = Console.ReadLine();

                resultado = Calculadora.Calcular(num1, num2, signo);

                Console.WriteLine($"El resultado es: {resultado}");

                Console.Write("¿Desea continuar ? (S / N): ");
                respuesta = Console.ReadLine();

            } while (Validador.ValidarRespuesta(respuesta));
        }
    }
}