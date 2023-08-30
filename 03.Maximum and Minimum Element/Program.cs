using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] inpute = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if(inpute[0] == 1)
                {
                    stack.Push(inpute[1]);
                }
                if(inpute[0] == 2)
                {
                    stack.Pop();
                }
                if(inpute[0]== 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                if(inpute[0]==4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }
            if(stack.Count > 0)
            {
                Console.Write(string.Join(", ", stack));
            }
        }
    }
}
