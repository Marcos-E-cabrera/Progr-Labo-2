using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U07_PuestoDeAtencion
{
    public class Negocio
    {
        // campos
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string? nombre;

        // Getter
        // <summary>
        // Obtiene el cliente actual que está siendo atendido en la caja.
        // </summary>
        public Cliente Cliente
        {
            get
            {
                return clientes.Peek();
            }
            set
            {
                if (!clientes.Contains(value))
                {
                    clientes.Enqueue(value);
                }
            }
        }

        // <summary>
        // Constructor por defecto que inicializa la caja en Caja1 y la cola de clientes.
        // </summary>
        private Negocio()
        {
            caja = new PuestoAtencion(Puesto.Caja1);
            clientes = new Queue<Cliente>();
        }

        // <summary>
        // Constructor que permite establecer el nombre del negocio.
        // </summary>
        // <param name="nombre">Nombre del negocio</param>
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        // <summary>
        // Comprueba si el negocio no está atendiendo al cliente especificado.
        // </summary>
        // <param name="n">Negocio a comprobar</param>
        // <param name="c">Cliente a comprobar</param>
        // <returns>True si el negocio no está atendiendo al cliente especificado, false en caso contrario</returns>
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        // <summary>
        // Atiende al siguiente cliente en la cola del negocio.
        // </summary>
        // <param name="n">Negocio a atender</param>
        // <returns>True si se atendió a un cliente con éxito, false en caso contrario</returns>
        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                Cliente cli = n.clientes.Dequeue();
                return n.caja.Atender(cli);
            }

            return false;
        }

        // <summary>
        // Agrega un nuevo cliente a la cola del negocio.
        // </summary>
        // <param name="n">Negocio a agregar el cliente</param>
        // <param name="c">Cliente a agregar</param>
        // <returns>True si se agregó el cliente con éxito, false en caso contrario</returns>
        public static bool operator +(Negocio n, Cliente c)
        {
            if (!n.clientes.Contains(c))
            {
                n.clientes.Enqueue(c);
                return true;
            }

            return false;
        }

        // <summary>
        // Comprueba si el negocio está atendiendo al cliente especificado.
        // </summary>
        // <param name="n">Negocio a comprobar</param>
        // <param name="c">Cliente a comprobar</param>
        // <returns>True si el negocio está atendiendo al cliente especificado, false en caso contrario</returns>
        public static bool operator ==(Negocio n, Cliente c)
        {
            return n.clientes.Contains(c);
        }

        // <summary>
        // Obtiene la cantidad de clientes pendientes en la cola del negocio.
        // </summary>
        public int ClientesPendientes
        {
            get
            {
                return clientes.Count;
            }
        }

    }
}
