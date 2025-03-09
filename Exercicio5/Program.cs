using System;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta;

            Console.WriteLine("Vamos descobrir qual animal foi escolhido!");
            Console.WriteLine("Digite 'S' para Sim e 'N' para Não.");

  
            Console.Write("É mamífero? ");
            resposta = Console.ReadLine().Trim().ToUpper();

            if (resposta == "S") 
            {
                Console.Write("É quadrúpede? ");
                resposta = Console.ReadLine().Trim().ToUpper();

                if (resposta == "S")  
                {
                    Console.Write("É carnívoro? ");
                    resposta = Console.ReadLine().Trim().ToUpper();

                    if (resposta == "S")
                        Console.WriteLine("Animal escolhido: LEÃO");
                    else
                        Console.WriteLine("Animal escolhido: CAVALO");
                }
                else 
                {
                    Console.Write("É bípede? ");
                    resposta = Console.ReadLine().Trim().ToUpper();

                    if (resposta == "S")  
                    {
                        Console.Write("É onívoro? ");
                        resposta = Console.ReadLine().Trim().ToUpper();

                        if (resposta == "S")
                            Console.WriteLine("Animal escolhido: HOMEM");
                        else
                            Console.WriteLine("Animal escolhido: MACACO");
                    }
                    else  
                    {
                        Console.Write("Ele voa? ");
                        resposta = Console.ReadLine().Trim().ToUpper();

                        if (resposta == "S")
                            Console.WriteLine("Animal escolhido: MORCEGO");
                        else
                            Console.WriteLine("Animal escolhido: BALEIA");
                    }
                }
            }
            else  
            {
                Console.Write("É uma ave? ");
                resposta = Console.ReadLine().Trim().ToUpper();

                if (resposta == "S")  
                {
                    Console.Write("Ela voa? ");
                    resposta = Console.ReadLine().Trim().ToUpper();

                    if (resposta == "N")  
                    {
                        Console.Write("Ela é tropical? ");
                        resposta = Console.ReadLine().Trim().ToUpper();

                        if (resposta == "S")
                            Console.WriteLine("Animal escolhido: AVESTRUZ");
                        else
                            Console.WriteLine("Animal escolhido: PINGUIM");
                    }
                    else  
                    {
                        Console.Write("Ela é uma ave de rapina? ");
                        resposta = Console.ReadLine().Trim().ToUpper();

                        if (resposta == "S")
                            Console.WriteLine("Animal escolhido: ÁGUIA");
                        else
                            Console.WriteLine("Animal escolhido: PATO");
                    }
                }
                else
                {
                    Console.WriteLine("Animal não identificado na lista.");
                }
            }

            Console.ReadKey();
        }
    }
}
