using System;
using System.Linq;

namespace _05._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestSquareRows = 2;
            int biggestSquareCols = 2;
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int colums = input[1];
            int[,] matrix = new int[rows, colums];
            for (int row = 0; row < rows; row++)
            {
                int[] elemts = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int colum = 0; colum < colums; colum++)
                {
                    matrix[row, colum] = elemts[colum];
                }
            }
            int maxSum = int.MinValue;
            int maxSumRowOne = 0;
            int maxSumColOne= 0;
            int maxSumRowTwo = 0;
            int maxSumColTwo = 0;
            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < colums; col++)
                {
                    
                    if(row + biggestSquareRows -1 < rows && col + biggestSquareCols -1  < colums)
                    {
                        sum = matrix[row, col] + matrix[row, col+1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            maxSumRowOne = matrix[row, col];
                            maxSumColOne = matrix[row, col + 1];
                            maxSumRowTwo = matrix[row + 1, col];
                            maxSumColTwo = matrix[row + 1, col + 1];

                        }
                    }
                   
                }
            }
            Console.Write($"{maxSumRowOne} {maxSumColOne}\n");
            Console.Write($"{maxSumRowTwo} {maxSumColTwo}\n");
            Console.WriteLine(maxSum);
        }
    }
}
