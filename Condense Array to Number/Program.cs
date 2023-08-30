using System;
using System.Linq;
namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int [] condesed = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                 condesed [i] = nums[i] + nums[i + 1];
                nums[i] = condesed[i];
            }
            Console.WriteLine(condesed);
            
        }
    }
}
