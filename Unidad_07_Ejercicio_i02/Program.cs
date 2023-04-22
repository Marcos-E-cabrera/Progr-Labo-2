/*
                                        Ejercicio I02 - ¿Consultaste el índice?
Consigna:
            Crear la clase Libro en una biblioteca de clases y el código necesario para acceder a las páginas mediante un valor numérico.
            
            - El descriptor de acceso get del indexador leerá la página pedida, siempre y cuando el subíndice se encuentre dentro 
            de un rango correcto, sino retornará un string vacío.
            - En el set, si la página existe (existe ese índice) le asignará el texto. 
            Si no existe (si el índice es superior al máximo existente), agregará una nueva página.
            - Crear un proyecto de consola y probar la clase en el método Main.
 */

using Libreria;

namespace Unidad_07_Ejercicio_i02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            libro[0] = "Esta es la primera página";
            libro[1] = "Esta es la segunda página";
            Console.WriteLine(libro[0]); // Imprime "Esta es la primera página"
            Console.WriteLine(libro[1]); // Imprime un string vacío, ya que no existe la página 2
            Console.WriteLine(libro[2]); // Imprime un string vacío, ya que no existe la página 2

        }
    }
}