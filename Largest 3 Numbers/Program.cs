using System;
using System.Linq;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            numbers = numbers.OrderByDescending(n => n).Take(3).ToList();
            Console.WriteLine(string.Join(" ", numbers));

        }
        
    }
}
