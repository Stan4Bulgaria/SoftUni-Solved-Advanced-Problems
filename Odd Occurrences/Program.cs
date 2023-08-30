using System;
using System.Collections.Generic;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> occurenceCounter = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                string counts = words[i].ToLower();
                if (!occurenceCounter.ContainsKey(counts))
                {
                    occurenceCounter.Add(counts, 0);
                }
                occurenceCounter[counts]++;
            }
            foreach (var count in occurenceCounter)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write($"{count.Key} ");
                }
            }
        }
}
    }
}
