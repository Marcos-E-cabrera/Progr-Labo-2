using System.Drawing;

namespace Metodos
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            return (valor >= min && valor <= max);
        }
        
        public static bool ValidarRespuesta( string respuesta )
        {
            string aux = respuesta.Trim(); // corta los esmpacios 
            aux = aux.ToUpper();

            return (aux == "S");
        }

    }
}