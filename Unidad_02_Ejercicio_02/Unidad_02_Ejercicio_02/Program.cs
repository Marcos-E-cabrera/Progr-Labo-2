/*
    Ejercicio I02 - ¿Desea continuar?
    
    Consigna:
    Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje 
    "¿Desea continuar? (S/N)".

    Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
    El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
*/

namespace Unidad_02_Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            bool continuar = true;

            while (continuar)
            {
                // pido numero
                Console.Write("Ingrese un número entero: ");
                int numero = int.Parse(Console.ReadLine());

                // sumo los numeros
                suma += numero;

                // pregunto 
                Console.Write("¿Desea continuar? (S/N): ");
                continuar = Validador.ValidarRespuesta(Console.ReadLine());
            }

            // muestro la suma
            Console.WriteLine("La suma total es: " + suma);
            Console.ReadLine();


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
}