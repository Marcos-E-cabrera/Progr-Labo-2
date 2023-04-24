using Metodos_U08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U08_I01
{
    public class Camion : VehiculoTerrestre
    {
        // Campos
        public short cantidadMarchas;
        public int pesoCarga;

        public short CantidadMarchas { get; set; }
        public int PesoCarga { get; set; }

        public Camion(short cantidadRuedas, short cantidadPuertas, eColores eColor, short cantidadMarchas, int pesoCarga)
             : base(cantidadRuedas, cantidadPuertas, eColor)
        {
            this.CantidadMarchas = cantidadMarchas;
            this.PesoCarga = pesoCarga;
        }
    }
}
