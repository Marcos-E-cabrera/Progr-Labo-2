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
            int i;
            int j;
            int k = 1;
            int e;

            int flag = 0;
            int altura;
            int espacios;

            Console.Write("Ingresar la \"ALTURA DEL TRIANGULO\" : ");
            altura = int.Parse(Console.ReadLine());

            while (altura < 1)
            {
                Console.Write("ERROR, Reingresar la \"ALTURA DEL TRIANGULO\"! : ");
                altura = int.Parse(Console.ReadLine());
            }

            espacios = altura;

            for (i = 0; i < altura; i++)
            {
                for (e = 0; e <= espacios; e++ )
                {
                    Console.Write(' ');
                }
                
                espacios--;

                for (j = 0; j < k; j++)
                {
                    Console.Write("*");

                    if (flag == 1)
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