using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_clase02
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial) 
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }
        public void SetNotaSegundoParcial(int notaSegundoParcial) 
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        private float CalcularPromedio()
        {
            int nota1;
            int nota2;
            float promedio;

            nota1 = this.notaPrimerParcial;
            nota2 = this.notaSegundoParcial;

            promedio = (float)(nota1 + nota2) / 2;

            return promedio;
        }

        public float Promedio
        {
            get { return CalcularPromedio(); }
        }

        public double CalcularNotaFinal()
        {
            double notaDelFinal = -1;

            if ( this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4) 
            { 
                notaDelFinal = random.Next(6, 10);
            }
            return notaDelFinal;
        }

        public double NotaFinal
        {
            get { return CalcularNotaFinal(); }
        }

        public string Mostrar()
        {
            StringBuilder aux = new StringBuilder();

            aux.AppendLine($"Nombre: {nombre}  Apellido: {apellido}  Legajo: {legajo}");
            aux.AppendLine($"Nota del primer y segundo parcial: {notaPrimerParcial}, {notaSegundoParcial}");
            aux.AppendLine($"Promedio: {Promedio}");

            if (NotaFinal == -1)
            {
                aux.AppendLine("Nota final: Alumno desaprobado");
            }
            else
            {
                aux.AppendLine($"Nota final: {NotaFinal}");
            }

            return aux.ToString();
        }
    }
}
