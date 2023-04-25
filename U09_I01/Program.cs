// https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/polimorfismo/Ejercicios/I01-sobre-sobrescribiendo-esas-advertencias/
using Metodos_U09;

namespace U09_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            //Sobrescrito objetoSobrescrito = new Sobrescrito();

            //Console.WriteLine(objetoSobrescrito.ToString());

            //string objeto = "¡Este es mi método ToString sobrescrito!";

            //Console.WriteLine("----------------------------------------------");
            //Console.Write("Comparación Sobrecargas con String: ");
            //Console.WriteLine(objetoSobrescrito.Equals(objeto));

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine(objetoSobrescrito.GetHashCode());
            Sobrescrito sobreSobrescrito = new SobreSobrescrito();

            Console.WriteLine(sobreSobrescrito.MiMetodo());

            Console.ReadKey();
        }
    }
}