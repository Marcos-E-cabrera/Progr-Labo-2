using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U03
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }


        public string Nombre
        {
            get { return this.nombre; }
            set 
            { 
                if ( value != null)
                { 
                    this.nombre = value;
                }
            }
        }

        public DateTime FechaDeNacimiento
        {
            get { return this.fechaDeNacimiento; }
            set { this.fechaDeNacimiento = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set 
            {
                if ( value > 00000000 && value < 99999999)
                {
                    this.dni = value; 
                }
            }
        }

        //CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
        private int CalcularEdad()
        {
            DateTime ahora = DateTime.Now; // 2023
            int edad = ahora.Year - fechaDeNacimiento.Year; // la edad actual de la persona.

            /*
             En estas líneas se ajusta la edad calculada en el paso anterior en caso de que la persona 
             no haya cumplido años todavía en el año actual. Para hacer esto, se compara la fecha de nacimiento
             de la persona con la fecha actual ajustada por la edad calculada (utilizando el método AddYears).
             Si la fecha de nacimiento de la persona es posterior a la fecha ajustada, significa que la persona no ha 
             cumplido años todavía en este año y se reduce la edad en 1 año.
             */
            if (fechaDeNacimiento > ahora.AddYears(-edad)) // fecha y hora hace ( 19 ) años
            {
                edad--;
            }

            return edad;
        }

        public int Edad
        {
            get { return CalcularEdad() ; }
        }

        //Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.

        public string Mostrar()
        {
            return $"\nNombre: {nombre}\nFecha de nacimiento: {fechaDeNacimiento}\nDNI: {dni}\nEdad actual: {Edad}";
        }

        // EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.

        public string EsMayorDeEdad()
        {
            if ( Edad >= 18 ) 
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor";
            }
        }




    }
}
