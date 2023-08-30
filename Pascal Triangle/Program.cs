using System;

namespace _07.Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] jaggedArray = new long [rows][];
            jaggedArray[0] = new long[1] { 1 };
            for (int row = 1; row < rows; row++)
            {
                jaggedArray[row] = new long[jaggedArray[row - 1].Length + 1];
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if(jaggedArray[row -1].Length > col)
                    {
                        jaggedArray[row][col] += jaggedArray[row - 1][col];
                    }
                    if(col > 0)
                    {
                        jaggedArray[row][col] += jaggedArray[row - 1][col - 1];
                    }
                    
                }
            }
            JaggedArray(jaggedArray);
        }
        static void JaggedArray(long[][] jagged)
        {
           
            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine($"{String.Join(" ", jagged[row])}");
            }
            
        }


    }
}
