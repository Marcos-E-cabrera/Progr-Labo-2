using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U06
{
    public class AutoF1
    {
        // campos
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        // Propiedades
        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return enCompetencia; }
            set { enCompetencia = value; }
        }

        public string Escuderia
        {
            get { return escuderia; }
            set { escuderia = value; }
        }

        public short Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set { vueltasRestantes = value; }
        }

        // Constructores
        public AutoF1(short numero, string escuderia)
        {
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.numero = numero;
            this.escuderia = escuderia;
        }

        // Métodos
        public string MostrarDatos()
        {
            StringBuilder dt = new StringBuilder();
            dt.AppendLine($"Numero: {numero}");
            dt.AppendLine($"Escuderia: {escuderia}");
            dt.AppendLine($"En Competencia: {enCompetencia}");
            dt.AppendLine($"Vueltas Restantes: {vueltasRestantes}");
            dt.AppendLine($"Cantidad Combustible: {cantidadCombustible}");
            return dt.ToString();
        }

        // Operadores sobrecargados 
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.Numero == a2.Numero) && (a1.Escuderia == a2.Escuderia);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

    }
}
