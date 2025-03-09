using System;

namespace Matriz4x4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];


            Console.WriteLine("Digite os 16 valores da matriz 4x4 (linha por linha):");
            for (int i = 0; i < 4; i++)
            {
                string[] valores = Console.ReadLine().Split();
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            int somaA = 0, somaB = 0, somaC = 0, somaD = 0;


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (i < 2 && j < 2)
                        somaA += matriz[i, j];

                    if (i >= 2 && j >= 2)
                        somaB += matriz[i, j];


                    if (i > j)
                        somaC += matriz[i, j];

                    if (i < j)
                        somaD += matriz[i, j];
                }
            }

            Console.WriteLine($"Soma da parte hachurada (a): {somaA}");
            Console.WriteLine($"Soma da parte hachurada (b): {somaB}");
            Console.WriteLine($"Soma da parte hachurada (c): {somaC}");
            Console.WriteLine($"Soma da parte hachurada (d): {somaD}");

            Console.ReadKey();
        }
    }
}
