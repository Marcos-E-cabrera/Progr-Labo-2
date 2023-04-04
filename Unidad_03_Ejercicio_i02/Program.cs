/*
Ejercicio I02 - ¿Vos cuántas primaveras tenés?
Consigna
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

    1- Deberá tener los atributos:
        nombre
        fechaDeNacimiento
        dni
        Deberá tener un constructor que inicialice todos los atributos.

    2- Construir los siguientes métodos para la clase:
        Setter y getter para cada uno de los atributos.

    3- CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
    4- Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
    5- EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
    6- Instanciar 3 objetos de tipo Persona en el método Main.
    7- Mostrar quiénes son mayores de edad y quiénes no.
 */
using Metodos_clase02;

namespace Unidad_03_Ejercicio_i02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Marcos cabrera", new DateTime(2003,4,21), 12345678);
            Console.WriteLine(persona.Mostrar());
            Console.WriteLine(persona.EsMayorDeEdad());

            Persona persona2 = new Persona("Raul Alessandro", new DateTime(2010, 7, 16), 12123444);
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad());

            Persona persona3 = new Persona("Micaela Recio", new DateTime(2001, 2, 6), 12727444);
            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());

        }
    }
}