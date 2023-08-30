using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortedDictionary<double, int> keyCounter = new SortedDictionary<double, int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (!keyCounter.ContainsKey(numbers[i]))
                {
                    keyCounter.Add(numbers[i], 0);
                }
                keyCounter[numbers[i]]++;
            }
            foreach (var item in keyCounter)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
