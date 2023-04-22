/*
                                                 Ejercicio C01 - Jugadores encapsulados
Consigna:
            Partir del ejercicio Estadística deportiva y realizar los siguientes cambios:

            - Agregar propiedades de sólo lectura a los atributos partidosJugados, promedioGoles y totalGoles de Jugador, y de lectura/escritura 
            a nombre y dni.
            - Quitar el atributo promedioGoles de jugador. Calcular dicho promedio dentro de la propiedad de sólo lectura PromedioDeGoles.
            - Quitar el método GetPromedioGoles, colocando dicha lógica en la respectiva propiedad.
            - Realizar todos los cambios necesarios para que vuelva a funcionar como antes.
 */

using EstadisticaDeportiva;

namespace Unidad_07_Ejercicio_i03
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
            Equipo equipo1 = new Equipo(2, "Equipo 1");
            bool agregado1 = equipo1 + jugador1;
            bool agregado2 = equipo1 + jugador2;
            bool agregado3 = equipo1 + jugador3;

            if (agregado1)
            {
                Console.WriteLine($"El jugador {jugador1.Nombre} fue agregado al equipo {equipo1.Nombre}.");
            }
            else
            {
                Console.WriteLine($"El jugador {jugador1.Nombre} no pudo ser agregado al equipo {equipo1.Nombre}.");
            }

            if (agregado2)
            {
                Console.WriteLine($"El jugador {jugador2.Nombre} fue agregado al equipo {equipo1.Nombre}.");
            }
            else
            {
                Console.WriteLine($"El jugador {jugador2.Nombre} no pudo ser agregado al equipo {equipo1.Nombre}.");
            }

            if (agregado3)
            {
                Console.WriteLine($"El jugador {jugador3.Nombre} fue agregado al equipo {equipo1.Nombre}.");
            }
            else
            {
                Console.WriteLine($"El jugador {jugador3.Nombre} no pudo ser agregado al equipo {equipo1.Nombre}.");
            }

            Console.WriteLine("\nDatos de los jugadores en el equipo:");
            Console.WriteLine(jugador1.MostrarDatos());
            Console.WriteLine(jugador2.MostrarDatos());
            Console.WriteLine(jugador3.MostrarDatos());




        }
    }
}