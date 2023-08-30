using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Fast_food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityForTheDay = int.Parse((Console.ReadLine()));
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());
            foreach (var item in queue)
            {
                if(item <= quantityForTheDay)
                {
                    quantityForTheDay -=  item;
                }
                else
                {
                    Console.WriteLine($"Orders left: {item}");
                    return;
                }
            }
            Console.WriteLine($"Orders complete");
            
           
        }
    }
}
