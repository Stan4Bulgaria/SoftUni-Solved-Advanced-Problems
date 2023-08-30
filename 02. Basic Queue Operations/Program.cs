using System;

using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inPuteElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numToPush = numbers[0];
            int numToPop = numbers[1];
            int specialNum = numbers[2];
            int smallestNum = int.MaxValue;
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < numToPush; i++)
            {
                queue.Enqueue(inPuteElements[i]);
            }
            for (int i = 0; i < numToPop; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }
            if (queue.Contains(specialNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                foreach (var item in queue)
                {
                    if (item < smallestNum)
                    {
                        smallestNum = item;
                    }
                }
                Console.WriteLine(smallestNum);
            }
        }
    }
}
