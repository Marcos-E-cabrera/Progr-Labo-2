using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U08_HerenciaDepotiva
{
    public class DirectorTecnico : Persona
    {
        // Campos
        private DateTime fechaNacimiento;

        // Propiedades
        private DirectorTecnico ( string nombre ) : base( nombre )
        {
            this.Nombre = nombre;
        }

        public DirectorTecnico ( string nombre, DateTime fechaNacimiento) : this( nombre )
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public static bool operator == ( DirectorTecnico dt1, DirectorTecnico dt2 )
        {

            return (dt1.Nombre == dt2.Nombre && dt1.fechaNacimiento == dt2.fechaNacimiento);
        }

        public static bool operator != (DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !dt1.Equals( dt2 );
        }

        public string MostrarDatos()
        {
            return $"\nDatos Director Tecnico:\nNombre: {Nombre}\nFecha Nacimiento: {fechaNacimiento.ToShortDateString()}";
        }
    }
}
