namespace PuestoDeAtencion
{
    public class Cliente
    {
        // campos
        private string? nombre;
        private int numero;

        // getter y setter
        public string? Nombre { get; set; }

        public int Numero { get; }

        // constructor
        // <summary>
        // Constructor que establece el número del cliente.
        // </summary>
        // <param name="numero">Número del cliente</param>
        public Cliente(int numero)
        {
            this.Numero = numero;
        }

        // <summary>
        // Constructor que establece el número y el nombre del cliente.
        // </summary>
        // <param name="numero">Número del cliente</param>
        // <param name="nombre">Nombre del cliente</param>
        public Cliente(int numero, string? nombre) : this(numero)
        {
            this.Nombre = nombre;
        }

        // <summary>
        // Sobrecarga del operador == para comparar dos clientes por su número.
        // </summary>
        // <param name="c1">Primer cliente</param>
        // <param name="c2">Segundo cliente</param>
        // <returns>True si los clientes tienen el mismo número, false en caso contrario</returns>
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return (c1.Numero == c2.Numero);
        }

        // <summary>
        // Sobrecarga del operador != para comparar dos clientes por su número.
        // </summary>
        // <param name="c1">Primer cliente</param>
        // <param name="c2">Segundo cliente</param>
        // <returns>True si los clientes tienen diferente número, false en caso contrario</returns>
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}