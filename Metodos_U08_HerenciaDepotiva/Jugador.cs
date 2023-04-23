namespace Metodos_U08_HerenciaDepotiva
{
    public class Jugador : Persona
    {
        // campos
        private int partidosJugados = 0;
        private float promedioGoles = 0;
        private int totalGoles;

        // propiedades
        public int PartidosJugados { get { return partidosJugados; } }

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

        public int TotalGoles { get { return totalGoles; }}

        // Metodos
        public Jugador( string nombre, int dni) : base(nombre, dni)
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this( nombre, dni)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public string MostrarDatos()
        {
            return $"\nNombre: {this.Nombre}\nDni: {this.Dni}\nPartidos Jugados: {this.partidosJugados}\nTotal Goles: {this.totalGoles}\nPromedio Goles: {this.PromedioGoles}";
        }
    }
}