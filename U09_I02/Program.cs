// https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/polimorfismo/Ejercicios/I02-calculadora-formas/
using Biblioteca = Metodos_U09_CalculadoraDeFormas; // ALIAS 

namespace U09_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cuando se utiliza el nombre de una clase se necesita indicar la ruta completa del espacio de nombres
            // para la clase a fin de evitar ambigüedades. 
            // sin Alias
            // List<Metodos_U09_CalculadoraDeFormas.Figura> figuras = new List<Metodos_U09_CalculadoraDeFormas.Figura>();

            // usando Alias 
            List<Biblioteca.Figura> figuras = new List<Biblioteca.Figura>();

            // Crea una instancia de un círculo, un cuadrado y un rectángulo, utilizando los constructores de cada clase
            var circulo = new Biblioteca.Circulo(1.5);
            var cuadrado = new Biblioteca.Cuadrado(3);
            var rectangulo = new Biblioteca.Rectangulo(4,8);

            // Agrega cada figura a la lista de figuras
            figuras.Add(circulo);
            figuras.Add(cuadrado);
            figuras.Add(rectangulo);

            // Recorre la lista de figuras e imprime información sobre cada figura
            foreach (var figura in figuras)
            {
                Console.WriteLine("=============== FIGURA ==================");

                // Imprime el tipo de figura utilizando el método GetType() de .NET
                Console.WriteLine($"Tipo: {figura.GetType()}");

                // Llama al método Dibujar() de cada figura e imprime el resultado
                Console.WriteLine(figura.Dibujar());

                // Llama al método CalcularSuperficie() de cada figura e imprime el resultado con 2 decimales
                Console.WriteLine($"Área: {figura.CalcularSuperficie():F2}");

                // Llama al método CalcularPerimetro() de cada figura e imprime el resultado con 2 decimales
                Console.WriteLine($"Perímetro: {figura.CalcularPerimetro():F2}");

                Console.WriteLine("==========================================");
            }

        }
    }
}