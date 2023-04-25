using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U09_CalculadoraDeFormas
{
    public sealed class Circulo : Figura
    {
        public override string Dibujar()
        {
            return "Dibujando círculo...";
        }

        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}
