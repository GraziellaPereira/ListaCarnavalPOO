using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vendaMedia, precoAtual, precoReajustado;
            Console.WriteLine("Vamos descobrir o valor do reajuste do seu produto.");
            Console.WriteLine("Digite o número da venda média mensal: ");
            vendaMedia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço atual: ");
            precoAtual = double.Parse(Console.ReadLine());

            if (vendaMedia < 500 && precoAtual < 30.00)
            {
                precoReajustado = ((precoAtual * 0.1) + precoAtual);

                Console.WriteLine("Preço reajustado: " + precoReajustado);
            } else if (vendaMedia >= 500 &&  precoAtual >= 30.00)
            {
                precoReajustado = (precoAtual - (precoAtual * 0.2));
                Console.WriteLine("Preço reajustado: " + precoReajustado);
            } else
            {
                Console.WriteLine("Não houve reajuste no preço.");
            }

            Console.ReadKey();

        }
    }
}
