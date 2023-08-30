using System;
using System.Linq;
namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumArrayOne = 0;
            int sumArrayTwo = 0;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                if(arrayOne[i] != arrayTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    sumArrayOne += arrayOne[i];
                    sumArrayTwo += arrayTwo[i];
                    
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sumArrayOne}");

        }
    }
}
