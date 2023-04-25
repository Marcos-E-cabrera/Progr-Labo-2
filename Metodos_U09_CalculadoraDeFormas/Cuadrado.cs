using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U09_CalculadoraDeFormas
{
    public sealed class Cuadrado : Rectangulo
    {
        public override string Dibujar()
        {
            return "Dibujando Cuadrado...";
        }

        public double Lado { get; set; }

        public Cuadrado(double lado) : base (lado, lado)
        {
            Lado = lado;
        }

        public override double CalcularSuperficie()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}
