using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U09
{
    public class SobreSobrescrito : Sobrescrito
    {
        /*
         5. Agregar una clase llamada SobreSobrescrito que herede de Sobrescrito. Implementar el código necesario para que todo funcione correctamente.
         6. Modificar el método Main para probar las modificaciones.
        */
        public override string MiPropiedad
        {
            get { return miAtributo; }
        }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
