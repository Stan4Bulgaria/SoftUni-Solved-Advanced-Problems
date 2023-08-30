using System;
using System.Linq;

namespace _03.Primary_diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int sum = 0;
            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row, row];
                 
            }
            Console.WriteLine(sum);
        }
    }
}
