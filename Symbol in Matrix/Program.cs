using System;
using System.Linq;
namespace _04._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            
            for (int rows  = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();
                for (int col= 0; col < n; col++)
                {
                    matrix[rows, col] = input[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int row = i;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int col = j;
                    if(matrix[row,col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                        
                    }
                    if (row == n-1 && col == n-1)
                    {
                        Console.WriteLine($"{symbol} does not occur in the matrix");
                    }
                }
            }
            
        }
      
    }
}
