using System;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int colums = input[1];
            int sum = 0;
            int[,] matrix = new int[rows, colums];
            for (int row = 0; row < rows; row++)
            {
                int[] elemts = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                
                for (int colum = 0; colum < colums; colum++)
                {
                    matrix[row, colum] = elemts[colum];
                }
            }
            foreach (var item in matrix)
            {
                sum += item;
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
