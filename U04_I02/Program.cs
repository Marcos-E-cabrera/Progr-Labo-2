//https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/sobrecarga/Ejercicios/I02-cotizador/
using Metodos_U04;
using Metodos_U04_Billetera;
using System.Drawing;

namespace U04_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dolar dolar = new Dolar(50); // carga forzada
            Dolar dolarA = 10; // implicita
            Dolar dolarB = 10; // implicita
            Dolar resultadoDolar;

            Peso peso = (Peso)dolarA; // explicita
            Euro euro = (Euro)dolarA; // explicita

            Console.WriteLine($"Convercion de Dolar a Pesos: {peso.GetCantidad()}");
            Console.WriteLine($"Convercion de Dolar a Euros: {euro.GetCantidad()}");

            Console.WriteLine($"\nLa convercion de Dolar a Peso es igul?: {dolarA == peso}");
            Console.WriteLine($"La convercion de Dolar a Peso es diferente?: {dolarA != peso}");
            Console.WriteLine($"\nLa convercion de Dolar a Euro es igul?: {dolarA == euro}");
            Console.WriteLine($"La convercion de Dolar a Euro es diferente?: {dolarA != euro}");

            Console.WriteLine($"\nEl DolarA es igual al DolarB?: {dolarA == dolarB}");
            Console.WriteLine($"El DolarA es diferente al DolarB?: {dolarA != dolarB}");

            Euro euroA = 2;
            Peso pesoA = 50000;

            resultadoDolar = dolarA - euroA;
            Console.WriteLine($"\nDolarA ({dolarA.GetCantidad()}) - EuroA ({euroA.GetCantidad()}) = {resultadoDolar.GetCantidad()} ");

            resultadoDolar = dolarA - pesoA;
            Console.WriteLine($"DolarA ({dolarA.GetCantidad()}) - PesoA ({pesoA.GetCantidad()}) = {resultadoDolar.GetCantidad()} ");

            resultadoDolar = dolarA + euroA;
            Console.WriteLine($"DolarA ({dolarA.GetCantidad()}) + EuroA ({euroA.GetCantidad()}) = {resultadoDolar.GetCantidad()} ");

            resultadoDolar = dolarA + pesoA;
            Console.WriteLine($"DolarA ({dolarA.GetCantidad()}) + PesoA ({pesoA.GetCantidad()}) = {resultadoDolar.GetCantidad()} ");


        }
    }
}