using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 20 números:");
            string[] d = Console.ReadLine().Split();
            int[] numeros = Array.ConvertAll(d, int.Parse);

            Console.WriteLine("Digite um número n:");
            int n = int.Parse(Console.ReadLine());

            int contador = 0;

            for (int i = 0; i < 20; i++)
            {
                if (numeros[i] > n)
                {
                    if (contador == 0)
                    {
                        Console.WriteLine("Números maiores que n:");
                    }
                    Console.WriteLine(numeros[i]);
                    contador++;
                } 
            }
            if (contador == 0)
            {
                Console.WriteLine("Não há nenhum número maior que n.");
            }

            Console.ReadKey();
        }
    }
}
