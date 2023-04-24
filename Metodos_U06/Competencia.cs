using System.Text;

namespace Metodos_U06
{
    public class Competencia
    {
        // campos 
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        public short CantidadCompetidores { get { return cantidadCompetidores; } }
        public short CantidadVueltas { get { return cantidadVueltas; } }
        public List<AutoF1> Competidores { get { return competidores; } }

        // Constructor
        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas)
            : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        // Métodos
        public string MostrarDatos()
        {
            StringBuilder dt = new StringBuilder();
            dt.AppendLine($"\nCantidad Competidores: {cantidadCompetidores}");
            dt.AppendLine($"Cantidad Vueltas: {cantidadVueltas}");
            dt.AppendLine("\nLista Competidores:");

            foreach (AutoF1 autoF1 in competidores)
            {
                if (autoF1 is AutoF1 competidor)
                {
                    dt.AppendLine(competidor.MostrarDatos());
                }
            }

            return dt.ToString();
        }

        // Sobrecarga de operadores
        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)(new Random().Next(15, 100));
                c.competidores.Add(a);
                return true;
            }

            return false;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }

            return false;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 autoF1 in c.competidores)
            {
                if (a == autoF1)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }




    }
}