using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h, pesoIdeal;
            string sexo;
            Console.WriteLine("Vamos descobrir o seu peso ideal.");
            Console.WriteLine("Digite seu sexo (F ou M): ");
            sexo = Console.ReadLine().ToUpper();
            if (sexo != "F" && sexo != "M")
            {
                Console.WriteLine("Digite M ou F!");
                return;
            }
            else
            {
                Console.WriteLine("Digite sua altura: ");
                h = double.Parse(Console.ReadLine());

                if (sexo == "F")
                {
                    pesoIdeal = (62.1 * h) - 44.7;
                }
                else
                {
                    pesoIdeal = (72.7 * h) - 58;
                }
                Console.WriteLine("Seu peso ideal é: " + pesoIdeal);
            }
           
            Console.ReadKey();
        } 
    }
}
