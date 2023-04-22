namespace EstadisticaDeportiva
{
    public class Jugador
    {   
        // campos
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        // constructores
        private Jugador()
        {
            partidosJugados = 0;
            totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        // propiedades
        public int Dni { get; set; }

        public string Nombre
        {
            get { return nombre; }
        }

        public int PartidosJugados
        {
            get { return partidosJugados; }
        }

        public float PromedioGoles
        {
            get
            {
                if (partidosJugados > 0)
                {
                    return (float)totalGoles / partidosJugados;
                }
                else
                {
                    return 0f;
                }
            }
        }

        public int TotalGoles
        {
            get { return totalGoles; }
        }

        // Metodos
        public string MostrarDatos()
        {
            return $"\nDatos Jugador\nNombre: {this.nombre}\nDNI: {this.dni}\nPartidos Jugados: {this.partidosJugados}\nTotal Goles: {this.totalGoles}\nPromedio Goles: {this.PromedioGoles}";
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
    }
}