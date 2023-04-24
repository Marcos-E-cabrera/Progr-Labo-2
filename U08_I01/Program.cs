/*                                              Ejercicio I01 - El viajar es un placer
Consigna:   
            Crear un proyecto de biblioteca de clases con las clases Automovil, Moto, Camion.

            1. Crear un enumerado Colores { Rojo, Blanco, Azul, Gris, Negro }
            2. Camion tendrá los atributos: 
                cantidadRuedas: short, 
                cantidadPuertas : short, 
                color : Colores, 
                cantidadMarchas : short, 
                pesoCarga : int.

            3. Automovil tendrá los atributos: 
                cantidadRuedas : short, 
                cantidadPuertas : short, 
                color : Colores, 
                cantidadMarchas : short, 
                cantidadPasajeros : int.

            4. Moto tendrá los atributos:
                cantidadRuedas : short,
                cantidadPuertas : short, 
                color : Colores, 
                cilindrada : short.

            5. Crearle a cada clase un constructor que reciba todos sus atributos.
            6. Crear la clase VehiculoTerrestre y abstraer la información necesaria de las clases anteriores. 
                Luego generar una relación de herencia entre ellas, según corresponda.

            7. VehiculoTerrestre tendrá un constructor que recibirá todos sus atributos. Modificar las clases que heredan de ésta para que lo reutilicen.
               Crear un proyecto de consola y generar el código necesario para probar las clases.
 */
using Metodos_U08;
using System.Drawing;

namespace U08_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(8, 2, eColores.Gris, 6, 15000);
            Console.WriteLine($"Camion: Ruedas: {camion.CantidadRuedas}, Puertas: {camion.CantidadPuertas}, Color: {camion.Color}, Marchas: {camion.CantidadMarchas}, Peso de carga: {camion.PesoCarga}");

            Automovil auto = new Automovil(4, 4, eColores.Azul, 5, 4);
            Console.WriteLine($"Automovil: Ruedas: {auto.CantidadRuedas}, Puertas: {auto.CantidadPuertas}, Color: {auto.Color}, Marchas: {auto.CantidadMarchas}, Pasajeros: {auto.CantidadPasajeros}");

            Moto moto = new Moto(2, 0, eColores.Rojo, 100);
            Console.WriteLine($"Moto: Ruedas: {moto.CantidadRuedas}, Puertas: {moto.CantidadPuertas}, Color: {moto.Color}, Cilindrada: {moto.Cilindrada}");

            Console.ReadKey();
        }
    }
}