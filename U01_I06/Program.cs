/*
                                            Ejercicio I06 - Años bisiestos
Consigna:
            Escribir un programa que determine si un año es bisiesto.
            Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400.
            Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
            
            IMPORTANTE: Utilizar sentencias de iteración, selectivas y el operador módulo (%).
 */
namespace U01_I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio;
            int fin;

            Console.Write("Ingrese el año de inicio: ");
            inicio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el año de fin: ");
            fin = int.Parse(Console.ReadLine());

            for (int anio = inicio; anio <= fin; anio++)
            {
                if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0) // multiplo de 4 y no multiplo de 100 o multiplo de 400
                {
                    Console.WriteLine("{0} es bisiesto", anio);
                }
            }
        }
    }
}