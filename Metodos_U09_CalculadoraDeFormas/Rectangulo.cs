using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U09_CalculadoraDeFormas
{
    public class Rectangulo : Figura
    {
        public override string Dibujar()
        {
            return "Dibujando Rectangulo...";
        }

        public double LadoA { get; set; }
        public double LadoB { get; set; }

        public Rectangulo(double ladoA, double ladoB)
        {
            LadoA = ladoA;
            LadoB = ladoB;
        }

        public override double CalcularSuperficie()
        {
            return LadoA * LadoB;
        }

        public override double CalcularPerimetro()
        {
            return 2 * LadoA + 2 * LadoB;
        }
    }
}
