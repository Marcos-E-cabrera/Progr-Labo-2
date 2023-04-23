using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Provincial  : Llamada
    {
        // campos
        protected eFranja franjaHoraria;

        // Propiedades
        public float CostoLlamada { get { return CalcularCosto(); } }

        // Metodos
        public Provincial(eFranja miFranja, Llamada llamada) 
            : this (llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino )
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, eFranja miFranja, float duracion, string destino)
            : base (duracion, destino, origen) 
        {
            this.franjaHoraria = miFranja;
        }

        public new string Mostrar()
        {
            StringBuilder datosLlamada = new ();
            datosLlamada.AppendLine($"Tipo de Provincial:");
            datosLlamada.AppendLine(base.Mostrar());
            datosLlamada.AppendLine($"Costo de llamada: {CostoLlamada}");
            datosLlamada.AppendLine($"Franja Horaria: {franjaHoraria}");

            return datosLlamada.ToString();
        }

        private float CalcularCosto()
        {
            float costo = 0;
            switch (franjaHoraria)
            {
                case eFranja.Franja_1:
                    costo = (float)0.99;
                    break;
                case eFranja.Franja_2:
                    costo = (float)1.25;
                    break;
                case eFranja.Franja_3:
                    costo = (float)0.66;
                    break;
            }
            return costo * duracion;
        }
    }
}
