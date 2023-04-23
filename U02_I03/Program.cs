/*                                          Ejercicio I03 - Conversor binario
Consigna:
            Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

            El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

            public string ConvertirDecimalABinario(int numeroEntero) {}

            El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

            public int ConvertirBinarioADecimal(int numeroEntero) {}

            IMPORTANTE: NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.
 */

using Metodos_U02;


namespace U02_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binario;
            int numero;

            // INICIO - BINARIO 
            Console.Write("Ingrese un numero entero: ");
            numero = int.Parse(Console.ReadLine());

            binario = Conversor.ConvertirDecimalABinario(numero);
            Console.WriteLine($"binaraio: {binario}");
            // FIN - BINARIO 

            // INICIO - DECIMAL 
            Console.Write("Ingrese un numero binario: ");
            binario = Console.ReadLine();

            numero = Conversor.ConvertirBinarioADecimal(binario);
            Console.WriteLine("Decimal: " + numero);
            // FIN - DECIMAL
        }
    }
}