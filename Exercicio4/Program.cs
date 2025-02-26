using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan horasMes;
            double salarioHora, salarioTotal;

            Console.WriteLine("Vamos calcular seu salário considerando horas extras. ");
            Console.WriteLine("Digite quantas horas foram trabalhadas no mês: ")
            horasMes = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Ótimo. Agora digite o seu salário por hora: ");
            salarioHora = double.Parse(Console.ReadLine());


        }
    }
}
