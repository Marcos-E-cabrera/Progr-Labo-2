// https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/colecciones/Ejercicios/C02-enciendan-sus-motores/
using Metodos_U06;

namespace U06_C02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(5, 10);
            AutoF1 auto1 = new AutoF1(1, "Ferrari");
            AutoF1 auto2 = new AutoF1(2, "Mercedes");
            AutoF1 auto3 = new AutoF1(3, "Red Bull");

            bool agregado1 = competencia + auto1;
            bool agregado2 = competencia + auto2;
            bool agregado3 = competencia + auto3;
            
            AnucioCompetencia(auto1, agregado1);
            AnucioCompetencia(auto2, agregado2);
            AnucioCompetencia(auto3, agregado3);


            Console.WriteLine(competencia.MostrarDatos());
        }

        public static void AnucioCompetencia(AutoF1 f1, bool valido)
        {
            if (!valido)
            {
                Console.WriteLine($"El F1 {f1.Numero} no pudo ser agregado a la Competencia");
            }
            else
            {
                Console.WriteLine($"El F1 {f1.Numero} fue agregado a la Competencia");
            }
        }
    }
}