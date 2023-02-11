/*
            Ejercicio I08 - El tiempo pasa...
    Consigna
    Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa 
    fecha hasta la fecha actual. Tener en cuenta los años bisiestos.

    Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

    Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
 */
using System.Globalization;

namespace Unidad_02_Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la fecha de nacimiento (dd/mm/yyyy):");
            string nacimiento = Console.ReadLine();
            //  usuario ingresa la fecha en formato "dd/mm/yyyy", por lo que
            //  se utiliza el método DateTime.ParseExact para parsear la fecha.
            DateTime fechaNacimiento = DateTime.ParseExact(nacimiento, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            int diasVividos = CalcularDiasEntreFechas(fechaNacimiento, DateTime.Now);

            Console.WriteLine("Días vividos: " + diasVividos);
        }

        public static int CalcularDiasEntreFechas(DateTime fecha1, DateTime fecha2)
        {
            TimeSpan diferencia = fecha2 - fecha1;
            return diferencia.Days;
        }
    }
}