using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Centralita
    {
        // campos
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        // Propiedades
        public float GananciasPorLocal { get; }
        public float GananciasPorProvincial { get; }
        public float GananciasPorTotal { get; }

        public List<Llamada> Llamadas { get; }

        // Metodos
        private float CalcularGanancia ( TipoLlamada tipo)
        {
            return 0;
        } 

        public Centralita ()
        {
            this.listaDeLlamadas= new List<Llamada> ();
        }

        public Centralita ( string nombreEmpresa )
        {
            this.razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {
            return "";
        }

        public void OrdenarLlamadas()
        {
            
        }
            
    }
}
