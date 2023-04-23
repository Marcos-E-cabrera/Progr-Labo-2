/*
                                            Ejercicio I03 - Los primos
    
CONSIGNA:
            1. Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            2. Validar que el dato ingresado por el usuario sea un número.
            3. Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            4. Si ingresa "salir", cerrar la consola.
            5. Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. 
                De lo contrario, cerrar la consola.
            
            IMPORTANTE:     Utilizar sentencias de iteración, selectivas y el operador módulo (%).
 */
namespace U01_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            char opcion;
            string input;             // input puede obtener un "INT" o "STRING"

            // - INICIO -  VALIDAR ENTRADA
            Console.Write("Ingrese un Numero o Salir: ");
            input = Console.ReadLine();

            while (input != "salir" && int.TryParse(input, out numero) == false) // 2, 3
            {
                Console.Write("ERROR, Reingrese un Numero o Salir!: ");
                input = Console.ReadLine();
            }
            // - FIN -  VALIDAR ENTRADA

            // - INICIO -  NUMERO PRIMO
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
                    Console.Write(" {0}", i); // 1
                }
            }
            // - FIN -  NUMERO PRIMO


            // - INICIO - PREGUNTAR SI DESEA SEGUIR INTERANDO
            Console.WriteLine("\nDesea seguir interando ( s / n ):");
            input = Console.ReadLine();

            while ((char.TryParse(input, out opcion) == false))
            {
                Console.WriteLine("ERROR, Reingresar ( s / n ):");
                input = Console.ReadLine();
            }

            if (opcion == 's')
            {
                Main(args);
            }

            // - FIN - PREGUNTAR SI DESEA SEGUIR INTERANDO        }
        }
    }