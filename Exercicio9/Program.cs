using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as 7 notas dos juízes: ");
            string[] notas = Console.ReadLine().Split();
            double[] nota = Array.ConvertAll(notas, x => double.Parse(x, CultureInfo.InvariantCulture));

            
            for (int i = 0; i < 7; i++)
            {
                if (nota[i] < 1 || nota[i] > 10)
                {
                    Console.WriteLine("Nota fora do intervalo de 1 a 10!");
                    Console.ReadKey();
                    return; 
                }
            }
            double maiorNota = double.MinValue;
            double menorNota = double.MaxValue;
            double notaFinal = 0;
            double somaNota = 0;

            for (int i = 0; i < 7; i++)
            {
                if (nota[i] > maiorNota)
                {
                    maiorNota = nota[i];
                }
                if (nota[i] < menorNota)
                {
                    menorNota = nota[i];
                }
                somaNota += nota[i];
            }
            notaFinal = somaNota - maiorNota - menorNota;
            Console.WriteLine($"Nota final: {notaFinal:F2}");
            Console.ReadKey();
        }
    }
}
