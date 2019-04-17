using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log_registor
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Hora;
            Double Tempo = 0;

            Console.WriteLine("Contador de horas de trabalho v1.0");
            Console.WriteLine("Digite 0 (zero) para finalizar");

            do
            {
                Console.WriteLine("Escreva o total de tempo consumido:");
                Hora = Convert.ToDouble(Console.ReadLine());
                Tempo += Hora;
                Console.WriteLine("No momento:" + Tempo);
            }
            while (Hora != 0);

            Console.WriteLine("Total:" + Tempo);
            Console.ReadKey();
        }
    }
}
