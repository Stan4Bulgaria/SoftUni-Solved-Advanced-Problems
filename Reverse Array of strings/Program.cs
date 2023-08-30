using System;
using System.Linq;

namespace Reverse_Array_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().Split().ToArray();
            for (int i = symbols.Length - 1; i >=0; i--)
            {
                Console.Write($"{symbols[i]} ");
            }
        }
    }
}
