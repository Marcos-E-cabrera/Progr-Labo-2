namespace clase_01
{
    internal class Program  // EntryPoint - "clase"
    {
        // atributos de una clase - "estados" - "variable dentro de una clase"

        public int num; // "variable global"

        static void Main(string[] args) 
        {
            int numero;
            string cadena;
            bool flag = false;


            cadena = "Hello, World";
            Console.WriteLine(cadena);

            numero = 23;
            Console.WriteLine($"Mi numero es {numero}"); // usar esto


        }

        internal int contar() // metodo  - "comportamiento"
        {
            return 2;
        }

    }
}