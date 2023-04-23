// https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/objetos/Ejercicios/I03-el-ejemplo-universal/
using Metodos_U03;

namespace U03_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Cabrera", "D0001", "Marcos");
            estudiante1.SetNotaPrimerParcial(9);
            estudiante1.SetNotaSegundoParcial(8);
            Console.WriteLine(estudiante1.Mostrar());

            Estudiante estudiante2 = new Estudiante("Pando", "D0002", "Luis");
            estudiante2.SetNotaPrimerParcial(2);
            estudiante2.SetNotaSegundoParcial(4);
            Console.WriteLine(estudiante2.Mostrar());

            Estudiante estudiante3 = new Estudiante("Cabral", "D0003", "Elias");
            estudiante3.SetNotaPrimerParcial(8);
            estudiante3.SetNotaSegundoParcial(7);
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}