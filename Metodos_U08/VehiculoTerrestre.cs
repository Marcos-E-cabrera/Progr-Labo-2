using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U08_I01;

namespace Metodos_U08
{
    public class VehiculoTerrestre
    {
        public short cantidadRuedas;
        public short cantidadPuertas;
        public eColores eColor;

        public short CantidadRuedas { get; set; }
        public short CantidadPuertas { get; set; }
        public eColores Color { get; set; }


        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, eColores eColor)
        {
            this.CantidadRuedas = cantidadRuedas;
            this.CantidadPuertas = cantidadPuertas;
            this.Color = eColor;
        }
    }
}
