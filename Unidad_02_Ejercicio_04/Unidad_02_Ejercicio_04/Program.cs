/*
                            Ejercicio I04 - La calculadora
    Consigna
    Realizar un programa que permita realizar operaciones matemáticas simples
    (suma, resta, multiplicación y división).

    Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

    Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y
    la operación matemática. El método devolverá el resultado de la operación.

    Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar 
    sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es 
    distinto de cero.

    Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar 
    (ingresando el caracter +, -, * o /).

    El usuario decidirá cuándo finalizar el programa.
 */

using System.ComponentModel.DataAnnotations;

namespace Unidad_02_Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            int resultado = 0;

            while (continuar)
            {
                // pido numeros
                Console.Write("Ingrese un número entero: ");
                int primerOperando = int.Parse(Console.ReadLine());

                Console.Write("Ingrese un número entero: ");
                int segundoOperando = int.Parse(Console.ReadLine());

                Console.Write("Ingrese un operados(+,-,*,/): ");
                char operacion = char.Parse(Console.ReadLine());

                // sumo los numeros
                resultado = Calculadora.Calcular(primerOperando, segundoOperando, operacion);

                // muestro la suma
                Console.WriteLine("El resultado es: " + resultado);
                
                // pregunto 
                Console.Write("¿Desea continuar? (S/N): ");
                continuar = Validador.ValidarRespuesta(Console.ReadLine());
            }

            Console.ReadLine();
        }
    }

    public static class Calculadora 
    {
        public static int Calcular( int primerOperando, int segundoOperando, char operacion) 
        {
            int resultado = 0;

            switch(operacion)
            {
                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;
                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;
                case '/':
                    if ( Validar(segundoOperando) )
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else
                    {
                        Console.WriteLine("El sengundo operando tiene que ser mayor que 0");
                    }
                    break;
                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;
            }

            return resultado;
        }

        private static bool Validar(int segundoOperando) // solo usar si es division 
        {
            return !( segundoOperando == 0 );
        }
    }

    public static class Validador // clase
    {
        public static bool ValidarRespuesta(string respuesta) // metodo
        {
            respuesta = respuesta.ToUpper();
            if (respuesta == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}