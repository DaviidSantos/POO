using System;

namespace Exercicio12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Tamanho da matriz: ");
            int n = Int32.Parse(Console.ReadLine());
            int negatives = 0;

            int[,] mat = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"mat[{i},{j}]");
                    mat[i,j] = Int32.Parse(Console.ReadLine());
                    if (mat[i,j] < 0)
                    {
                        negatives++;
                    }
                }
            }

            Console.Write("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{mat[i,i]} ");
            }
            
            Console.Write($"\nNegative numbers: {negatives}");
            
        }
    }
}