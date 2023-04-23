using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U08_CentralTelefonica
{
    public class Centralita
    {
        // campos
        private List<Llamada> listaDeLlamadas;
        protected string? razonSocial;

        // Propiedades
        public float GananciasPorLocal { get { return CalcularGanancia(eTipoLlamada.Local); } }
       
        public float GananciasPorProvincial { get { return CalcularGanancia(eTipoLlamada.Provincial); } }
        
        public float GananciasPorTotal { get { return CalcularGanancia(eTipoLlamada.Todas); } }
        
        public List<Llamada> Llamadas { get { return listaDeLlamadas; } }


        // Metodos
        public Centralita ()
        {
            listaDeLlamadas = new List<Llamada> ();
        }

        public Centralita ( string nombreEmpresa ) 
            : this ()
        {
            this.razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {
            StringBuilder datosLlamada = new ();
            datosLlamada.AppendLine("--------------------------");
            datosLlamada.AppendLine($"Razon social: {razonSocial}");
            datosLlamada.AppendLine("Detalle de las llamadas:");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local llamadaLocal)
                {
                    datosLlamada.AppendLine($"{llamadaLocal.Mostrar()}");
                }
                else if ( llamada is Provincial llamadaProvincial )
                {
                    datosLlamada.AppendLine($"{llamadaProvincial.Mostrar()}");
                }
            }

            return datosLlamada.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private float CalcularGanancia(eTipoLlamada tipo)
        {
            float ganancia = 0;

            if ( tipo == eTipoLlamada.Local || tipo == eTipoLlamada.Todas )
            {
                foreach(Llamada llamada in listaDeLlamadas)
                {
                    if ( llamada is Local llamadaLocal) // casteo a Local
                    {
                        ganancia += llamadaLocal.CostoLlamada;
                    }
                }
            }

            if (tipo == eTipoLlamada.Provincial || tipo == eTipoLlamada.Todas)
            {
                foreach (Llamada llamada in listaDeLlamadas)
                {
                    if (llamada is Provincial llamadaProvincial)
                    {
                        ganancia += llamadaProvincial.CostoLlamada;
                    }
                }
            }

            return ganancia;
        }
    }
}
