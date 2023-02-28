using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_02_Ejercicio_01
{
    internal class Funciones
    {
       public static bool Validar(int valor, int min, int max)
       {
           return valor >= min && valor <= max;
       }
    }
}
