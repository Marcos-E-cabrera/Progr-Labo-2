using HerenciaDeportiva;

namespace Unidad_08_Ejercicio_C01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos algunos jugadores
            Jugador jugador1 = new Jugador(12345678, "Lionel Messi", 200, 400);
            Jugador jugador2 = new Jugador(23456789, "Cristiano Ronaldo", 220, 420);
            Jugador jugador3 = new Jugador(34567890, "Neymar Jr", 100, 200);

            // Creamos un equipo y agregamos los jugadores
            Equipo equipo1 = new Equipo(2, "River Plate");

            // Creamos algunos directores tecnicos
            DirectorTecnico directorTecnico1 = new DirectorTecnico("Martín Demichelis", new DateTime (1980, 12, 20));
            DirectorTecnico directorTecnico2 = new DirectorTecnico("Martín Demichelis", new DateTime(1980, 12, 20));
            DirectorTecnico directorTecnico3 = new DirectorTecnico("Marcelo Gallardo", new DateTime(1976, 01, 18));

            bool agregado1 = equipo1 + jugador1;
            bool agregado2 = equipo1 + jugador2;
            bool agregado3 = equipo1 + jugador3;
            bool dtAgregado2 = (directorTecnico2 == directorTecnico1);
            bool dtAgregado3 = (directorTecnico3 == directorTecnico1 && directorTecnico3 == directorTecnico2);

            AnuncioJugador(jugador1, equipo1, agregado1);
            AnuncioJugador(jugador2, equipo1, agregado2);
            AnuncioJugador(jugador3, equipo1, agregado3);

            Console.WriteLine("\nDatos de los jugadores en el equipo:");
            Console.WriteLine(jugador1.MostrarDatos());
            Console.WriteLine(jugador2.MostrarDatos());
            Console.WriteLine(jugador3.MostrarDatos());

            Console.WriteLine("\n");

            AnucioDirectorTecnico(directorTecnico1, equipo1,false);
            AnucioDirectorTecnico(directorTecnico2, equipo1, dtAgregado2);
            AnucioDirectorTecnico(directorTecnico3, equipo1, dtAgregado3);

            Console.WriteLine("\nDatos de los DTs:");
            Console.WriteLine(directorTecnico1.MostrarDatos());
            Console.WriteLine(directorTecnico3.MostrarDatos());


        }

        public static void AnucioDirectorTecnico ( DirectorTecnico dt, Equipo e, bool valido )
        {
            if (valido)
            {
                Console.WriteLine($"El jugador {dt.Nombre} no pudo ser agregado al equipo {e.Nombre}.");
            }
            else
            {
                Console.WriteLine($"El jugador {dt.Nombre} fue agregado al equipo {e.Nombre}.");
            }
        }

        public static void AnuncioJugador ( Jugador j, Equipo e, bool valido)
        {
            
            if (valido)
            {
                Console.WriteLine($"El jugador {j.Nombre} fue agregado al equipo {e.Nombre}.");
            }
            else
            {
                Console.WriteLine($"El jugador {j.Nombre} no pudo ser agregado al equipo {e.Nombre}.");
            }
        }
    }
}