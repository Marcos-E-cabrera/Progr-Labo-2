/*
    Ejercicio I03 - Los primos
    
    CONSIGNA:
    1. Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

    2. Validar que el dato ingresado por el usuario sea un número.

    3. Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

    4. Si ingresa "salir", cerrar la consola.

    5. Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. 
    De lo contrario, cerrar la consola.

    IMPORTANTE: 
    Utilizar sentencias de iteración, selectivas y el operador módulo (%).
 */

namespace Unidad_01_Introduccion_Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string input;
            int opcion;

            // input puede obtener un "INT" o "STRING"
            Console.Write("Ingrese un \"Numero\" o \"Salir\" para Cerrar la apliacion: ");
            input = Console.ReadLine();

            /* OUT = es como un puntero, espera que le asignen un valor.
             * TryParse = si el "STRING" es un numero lo parsea a "INT" y lo guarda en "numero"
             *            ( tambien devuelve un booleano)  
             */
            while (input != "salir" && int.TryParse(input, out numero) == false) // 2, 3
            {
                // Si input es diferente a salir y input es igual a false ( no es un numero ), va a pedir reingresar
                Console.Write("ERROR, !Reingrese un \"Numero\" o \"Salir\"!: ");
                input = Console.ReadLine();
            }

            for (int i = 1; i <= numero; i++)
            {
                int contador = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) //veo si es un numero primo
                    {
                        contador++;
                    }
                }

                if (contador <= 2)
                {
                    Console.Write(" {0}",i); // 1
                }
            }

            // 5
            Console.Write("\n\nDesea seguir interando?\n1.SI\n2.NO\nRespuesta: ");
            input = Console.ReadLine();

            while (!(int.TryParse(input, out opcion)) || (opcion != 1 && opcion != 2))
            {
                Console.Write("\nERROR, Reingresar: 1.SI 2.NO\nRespuesta: ");
                input = Console.ReadLine();
            }

            if (opcion == 1)
            {
                Main(args);
            }

        }
    }
}