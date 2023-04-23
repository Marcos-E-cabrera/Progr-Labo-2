using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_U03
{
    public class Boligrafo
    {
        public short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo (ConsoleColor color, short tinta)
        {
            this.color = color;
           SetTinta(tinta);
        }

        public ConsoleColor GetColor() 
        {
            return this.color;
        }

        public short GetTinta() 
        {
            return this.tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool validar = false;
            dibujo = "";

            if (gasto > this.tinta)
            {
                gasto = this.tinta;
            }

            if (gasto > 0)
            {
                dibujo = new string('*', gasto);
                tinta -= gasto;
                Console.ForegroundColor = color; // cambia el color
                Console.Write(dibujo); 
                Console.ResetColor(); // reseta el color
                validar = true;
            }

            return validar;
        }

        public void Recargar()
        {
           SetTinta(cantidadTintaMaxima);
        }

        private void SetTinta( short tinta )
        {
            if ( tinta >= 0 && tinta <= cantidadTintaMaxima )
            {
                this.tinta = tinta;
            }            
        }

    }
}
