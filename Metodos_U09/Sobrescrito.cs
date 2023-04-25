namespace Metodos_U09
{
    public abstract class Sobrescrito
    {

        /* Parte 1
         1.  Sobrescribir el método ToString para que retorne "¡Este es mi método ToString sobrescrito!".
         2.  Sobrescribir el método Equals para que retorne true si son del mismo tipo (objetos de la misma clase), false caso contrario.
         3.  Sobrescribir el método GetHashCode para que retorne el número 1142510181.
         */
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!"; 
        }

        public override bool Equals(object? obj)
        {
            return  obj is object;
        }

        public override int GetHashCode() 
        {
            return 1142510181;
        }

        /* Parte II
        1. Agregar a la clase Sobrescrito un atributo miAtributo del tipo string, con visibilidad protected.
        2. Generar un constructor de instancia que inicialice miAtributo con el valor "Probar abstractos".
        3. Agregará propiedad abstracta MiPropiedad de sólo lectura. Una vez implementada, retornará el valor de miAtributo.
        4. Crear un método abstracto MiMetodo que retorne un string. Una vez implementada, retornará el valor de MiPropiedad.
        */

        protected string miAtributo;

        public Sobrescrito()
        {
            miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();

    }
}