using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class Calculadora
    {
        public static int Calcular ( int x, int y, String operacion)
        {
            int cuenta = 0;
            switch(operacion)
            {
                case "+":
                    cuenta = ( x + y ) ;
                break; 
                case "-":
                    cuenta = ( x - y ) ;
                break;
                case "*":
                    cuenta = ( x * y ) ;
                break;
                case "/":
                    if ( Validar(y) )
                    {
                        cuenta = ( x / y ) ;
                    }              
                break;
                default:
                    Console.WriteLine("(!) Error");
                break;
            }

            return cuenta;
        }

        private static bool Validar(int y)
        {
            return (y != 0);
        }


    }
}
