using System;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os 5 números do gabarito da LOTO separados por espaço:");
            string[] loto = Console.ReadLine().Split();
            int[] numerosGabarito = Array.ConvertAll(loto, int.Parse); 

            Console.WriteLine("Digite a aposta de 10 números separados por espaço:");
            string[] a = Console.ReadLine().Split();
            int[] apostas = Array.ConvertAll(a, int.Parse); 

            int pontos = 0;

            foreach (int aposta in apostas)
            {
                foreach (int numero in numerosGabarito)
                {
                    if (aposta == numero)
                    {
                        pontos++;
                        break; 
                    }
                }
            }

            Console.WriteLine($"A aposta fez {pontos} pontos.");
            Console.ReadKey();
        }
    }
}
