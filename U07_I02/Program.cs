// https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/encapsulamiento/Ejercicios/I02-consultaste-el-indice/
using Metodos_U07_Libreria;

namespace U07_I02
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