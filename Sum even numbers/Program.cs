using System;
using System.Linq;

namespace Sum_even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumOfEvenNum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] % 2 == 0)
                {
                    sumOfEvenNum += nums[i];
                }
            }
            Console.WriteLine(sumOfEvenNum);
        }
    }
}
