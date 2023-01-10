/*
        Ejercicio I09 - Dibujando un triángulo equilátero

        Consigna
        Escribir un programa que imprima por consola un triángulo como el siguiente:

                                                    *
                                                   ***
                                                  *****
                                                 *******
                                                *********

        El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, 
        la altura ingresada fue de 5.

        IMPORTANTE
        Utilizar sentencias de iteración y selectivas.
 */
namespace Unidad_01_Introduccion_Ejercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lineaActual; 
            int asterisco; 
            int altura; 
            int espacios;

            /// VALIDAR NUMERO POSITIVO
            Console.Write("Ingresar la \"ALTURA DEL TRIANGULO\" : ");
            altura = int.Parse(Console.ReadLine());

            while (altura < 1)
            {
                Console.Write("ERROR, Reingresar la \"ALTURA DEL TRIANGULO\"! : ");
                altura = int.Parse(Console.ReadLine());
            }
            /// FIN

            // INICIO DEL TRIANGULO
            for (lineaActual = 1; lineaActual <= altura; lineaActual++) 
            {
                // lineaActual( 1 )
                // altura( 5 )
                for (espacios = 0; espacios < ( altura - lineaActual )  ; espacios++)
                {
                    // espacios( 0 )
                    // altura( 5 ) - lineActual( 1 ) = 4
                    Console.Write(" "); // espacios( 4 ) = (" ")
                }

                for (asterisco = 0; asterisco < (lineaActual * 2) - 1 ; asterisco++)
                {
                    // asterisco( 0 )
                    // ( lineaActual( 1 ) * 2 =  2 ) - 1 = 1
                    // asterisco( 1 ) = ( "*" )
                    Console.Write("*");
                }

                // salto de linea
                Console.Write("\n");
            }
        }
    }
}