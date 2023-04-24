using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U08
{
    public class Moto : VehiculoTerrestre
    {
        //camspos
        public short cilindrada;

        public short Cilindrada { get; set; }

        // Constructores
        public Moto(short cantidadRuedas, short cantidadPuertas, eColores eColor, short cilindrada)
            : base ( cantidadRuedas, cantidadPuertas, eColor)
        {
            this.Cilindrada = cilindrada;
        }

    }
}
