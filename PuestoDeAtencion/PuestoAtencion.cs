using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuestoDeAtencion
{
    public class PuestoAtencion
    {
        // Cmapos
        private static int numeroActual;
        private Puesto puesto;

        // getter
        // <summary>
        // Obtiene y actualiza el número actual de clientes atendidos.
        // </summary>
        public int NumeroActual
        {
            get
            {
                return ++numeroActual;
            }
        }

        // <summary>
        // Constructor por defecto que establece el puesto en Caja1.
        // </summary>
        private PuestoAtencion()
        {
            puesto = Puesto.Caja1;
        }

        // <summary>
        // Constructor que permite establecer un puesto específico.
        // </summary>
        // <param name="puesto">Puesto a asignar</param>
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        // <summary>
        // Atiende al cliente especificado.
        // </summary>
        // <param name="cliente">Cliente a atender</param>
        // <returns>True si se atendió al cliente con éxito, false en caso contrario</returns>
        public bool Atender(Cliente cliente)
        {
            Console.WriteLine($"\nAtendiendo cliente {cliente.Nombre} en {puesto}");
            Thread.Sleep(2000);
            Console.WriteLine($"Finalizada la atención del cliente {cliente.Nombre}");
            return true;
        }



    }
}
