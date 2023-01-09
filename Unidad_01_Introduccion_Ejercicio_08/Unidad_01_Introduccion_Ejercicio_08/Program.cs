/*
        Ejercicio I08 - Dibujando un triángulo rectángulo
        
        Consigna:
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
namespace Unidad_01_Introduccion_Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int k = 1;
            int flag = 0;
            int altura;

            Console.Write("Ingresar la \"ALTURA DEL TRIANGULO\" : ");
            altura = int.Parse(Console.ReadLine());

            while ( altura < 1 )
            {
                Console.Write("ERROR, Reingresar la \"ALTURA DEL TRIANGULO\"! : ");
                altura = int.Parse(Console.ReadLine());
            }

            for ( i = 0; i < altura; i++ )
            {
                for (j = 0; j < k; j++)
                {
                    Console.Write("*");

                    if ( flag == 1 )
                    {
                        k += 2;
                        flag = 0;
                    }
                }

                flag = 1;
                Console.Write("\n");

            }
        }
    }
}