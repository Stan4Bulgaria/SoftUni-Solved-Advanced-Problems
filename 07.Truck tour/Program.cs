using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Truck_tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();
            
            for (int i = 0; i < N; i++)
            {
                int[] inpute = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(inpute);
            }
            int startIndex = 0;
            while (true)
            {
                bool isComplete = true;
                int totalLitters = 0;
                foreach (int[] item in queue)
                {
                    int litters = item[0];
                    int distance = item[1];
                    totalLitters += litters;
                    if (totalLitters - distance < 0)
                    {
                        startIndex++;
                        int[] currentPump = queue.Dequeue();
                        queue.Enqueue(currentPump);
                        isComplete = false;
                        break;
                    }
                    totalLitters -= distance;
                }
                if (isComplete)
                {
                    Console.WriteLine(startIndex);
                    break;

                }

            }
           

        }
    }
}
