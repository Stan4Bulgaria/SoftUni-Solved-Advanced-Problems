using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            
            int[][] jagged = JaggedArray(rows);
            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if (row < 0 || col < 0 || row >=jagged.Length || col >= jagged[row].Length )
                {
                    Console.WriteLine("Invalid coordinates");
                    
                }
                else if(command[0] == "Add")
                {
                    jagged[row][col] += value;
                }
                else if (command[0] == "Subtract")
                {
                    jagged[row][col] -= value;
                }
                command = Console.ReadLine().Split();
            }
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col= 0; col < jagged[row].Length; col++)
                {
                    Console.Write($"{jagged[row][col]} ");
                }
                Console.WriteLine();
            }

        }
        static int[][] JaggedArray(int rows)
        {
            int[][] jaggedArray = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            return jaggedArray;
        }
        
    }
}
