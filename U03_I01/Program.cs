/*                                           Ejercicio I01 - Creo que necesito un préstamo
Consigna:
            Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

            Deberá tener los atributos:

            titular que contendrá la razón social del titular de la cuenta.
            cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
            Construir los siguientes métodos para la clase:

            Un constructor que permita inicializar todos los atributos.
            Un método getter para cada atributo.
            mostrar retornará una cadena de texto con todos los datos de la cuenta.
            ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
            retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
            En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
 */

using Metodos_U03;

namespace U03_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Marcos cabrera", 5000m);
            Console.WriteLine(cuenta.Mostrar());

            cuenta.Ingresar(1000m);
            Console.WriteLine("> Se ha ingresado $1000.");
            Console.WriteLine(cuenta.Mostrar());

            cuenta.Retirar(2000m);
            Console.WriteLine("> Se ha retirado $2000.");
            Console.WriteLine(cuenta.Mostrar());

            cuenta.Retirar(5000m);
            Console.WriteLine("> Se ha retirado $5000.");
            Console.WriteLine(cuenta.Mostrar());

            Console.ReadKey();
        }
    }
}