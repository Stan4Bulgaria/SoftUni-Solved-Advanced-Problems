using System;
using System.Linq;

namespace _02.Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int colums = matrixSize[1];
            int columSum = 0;
            int[,] matrix = new int[rows, colums];
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < colums; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int J = 0; J < matrix.GetLength(0); J++)
                {
                    columSum += matrix[J, i];
                }
                Console.WriteLine(columSum);
                columSum = 0;
            }
        }
    }
}
