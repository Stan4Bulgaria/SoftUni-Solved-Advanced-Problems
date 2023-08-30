using System;
using System.Collections.Generic;
using System.Linq;

namespace _2D.List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>>();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            for (int row = 0; row < rows; row++)
            {
                matrix.Add(Console.ReadLine().Split().Select(int.Parse).ToList());
                //matrix.Add(new List<int>(cols));
                //for (int col = 0; col < cols; col++)
                //{
                //    matrix[row].Add(int.Parse(Console.ReadLine()));
                //}
            }
            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < cols; col++)
                {
                    Console.Write($" {matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
