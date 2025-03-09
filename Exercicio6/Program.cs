using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            int numerador = 1, denominador = 1;

            for (int i = 0; i < 50; i++) {
                s += (double)numerador / denominador;
                numerador += 2;
                denominador += 1;

                
                
            }
            Console.WriteLine($"{s:F2}");
            Console.ReadKey();
        }
    }
}
