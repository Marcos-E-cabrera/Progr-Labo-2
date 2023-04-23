namespace Metodos_U04
{
    public class Sumador
    {
        // Campo
        private int cantidadSumas;

        // Constructores
        public Sumador()
        {
            cantidadSumas = 0;
        }

        public Sumador(int cantidadSumas) : this()
        {
            this.cantidadSumas = cantidadSumas;
        }

        // Metodos
        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            cantidadSumas += 1;
            return $"{a} {b}";
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }

    }
}