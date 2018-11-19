using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPed, quantItem;
            double p100, p101, p102, p103, p104, p105;
            p100 = 1.20;
            Console.WriteLine("Digite o nº do pedido:");
            nPed = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite a quantidade:");
            quantItem = Convert.ToInt16(Console.ReadLine());
        }
    }
}
