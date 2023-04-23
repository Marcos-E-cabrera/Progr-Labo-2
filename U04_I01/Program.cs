//https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/sobrecarga/Ejercicios/I01-sumador/
using Metodos_U04;

namespace U04_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicita
            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 9;

            //Console.WriteLine($"Valor del objeto NumeroBinario: {objBinario.GetBinario()}");
            //Console.WriteLine($"Valor del objeto NumeroDecimal: {objDecimal.GetDecimal()}");

            //explicita
            double numeroDecimal = (double)objDecimal;
            string binario = (string)objBinario;

            Console.WriteLine(binario);
            Console.WriteLine(numeroDecimal);

            numeroDecimal = Conversor.ConvertirBinarioADecimal(binario);
            Console.WriteLine($"NumeroBinario a NumeroDecimal: {numeroDecimal}");

            binario = Conversor.ConvertirDecimalABinario(numeroDecimal);
            Console.WriteLine($"NumeroDecimal a NumeroBinario: {binario}");
        }
    }
}