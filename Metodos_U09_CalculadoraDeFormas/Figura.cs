namespace Metodos_U09_CalculadoraDeFormas
{
    public abstract class Figura
    {
        public virtual string Dibujar()
        {
            return "Dibujando forma...";
        }

        public abstract double CalcularSuperficie();

        public abstract double CalcularPerimetro();

    }
}