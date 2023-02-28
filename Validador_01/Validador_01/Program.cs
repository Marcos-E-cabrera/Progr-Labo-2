namespace Validador_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Validador.ValidateName("marcos", 20, "cabrera", 10)); // True

           
        }

        static class Validador
        {
            public static bool ValidateName(string nombre, int longitudNombre, string apellido, int longitudApellido)
            {
                if (nombre.Length <= longitudNombre && apellido.Length <= longitudApellido)
                {
                    return true;
                }

                return false;
            }
        }
    }
}