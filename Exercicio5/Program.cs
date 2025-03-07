using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mamifero, quadrupede, carnivoro, herbivoro, bipede, onivoro;
            Console.WriteLine("Vamos descobrir qual animal será escolhido: digite S para sim e N para não em cada uma das perguntas: ");
            Console.WriteLine("É mamífero? ");
            mamifero = Console.ReadLine().Trim().ToUpper();
            
            
            Console.WriteLine("É Herbívoro? ");
            herbivoro = Console.ReadLine().Trim().ToUpper();

            if (mamifero == "S")
            {
                Console.WriteLine("É quadrúpede? ");
                quadrupede = Console.ReadLine().Trim().ToUpper();

                if (quadrupede == "S") {
                    Console.WriteLine("É Carnívoro? ");
                    carnivoro = Console.ReadLine().Trim().ToUpper();

                    if (carnivoro == "S")
                    {
                        Console.WriteLine("Animal escolhido: LEÃO");
                    }
                    else
                    {
                        Console.WriteLine("Animal escolhido: CAVALO");
                    }
                }  else
                {
                    Console.WriteLine("É bípede? ");
                    bipede = Console.ReadLine().Trim().ToUpper();

                    if (bipede == "S") {
                        Console.WriteLine("É onívoro? ");
                        onivoro = Console.ReadLine().Trim().ToUpper();

                        if (onivoro == "S") {
                            Console.WriteLine("Animal escolhido: HOMEM");
                        } else
                        {
                            Console.WriteLine("Animal escolhido: MACACO");
                        }
                    }
                }
            }
        }
    }
}
