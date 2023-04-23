using System.Threading;

namespace Metodos_U03
{
    public class Cuenta
    {
        /*
            titular que contendrá la razón social del titular de la cuenta.
            cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
            Construir los siguientes métodos para la clase:

            Un constructor que permita inicializar todos los atributos.
            Un método getter para cada atributo.

            mostrar retornará una cadena de texto con todos los datos de la cuenta.
            ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
            retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
            En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
         */

        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Getter_Titular
        {
            get
            {
                return Getter_Titular;
            }
        }

        public decimal Getter_Cantidad
        {
            get
            {
                return Getter_Cantidad;
            }
        }

        // mostrar retornará una cadena de texto con todos los datos de la cuenta.
        public string Mostrar()
        {
            return $"Titular: {titular}\nCantidad: {cantidad}";
        }

        // ingresar recibirá un monto para acreditar a la cuenta.Si el monto ingresado es negativo, no se hará nada.
        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                cantidad += monto;
            }
        }

        // retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
        public void Retirar(decimal monto)
        {
            if (monto > 0)
            {
                cantidad -= monto;
            }
        }
    }
}