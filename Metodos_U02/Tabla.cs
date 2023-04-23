using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U02
{
    public class Tabla
    {
        public static string TablaDeMultiplicacion(int numero)
        {
            StringBuilder tabla = new StringBuilder();  // se crea un objeto StringBuilder llamado "tabla"
            tabla.Append($"Tabla de multiplicar del número {numero}:\n"); // usa interpolación de cadenas para incluir el número.

            for (int i = 1; i <= 10; i++)
            {
                tabla.Append($"{numero} x {i} = {numero * i}\n");
            }

            return tabla.ToString(); // se devuelve la tabla completa como una cadena de texto.
        }
    }
}
