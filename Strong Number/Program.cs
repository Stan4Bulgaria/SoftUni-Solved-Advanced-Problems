using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int temNum = num;
            int factorialSum = 0;
            while (temNum > 0)
            {
                int currentNum = temNum % 10;
                temNum /= 10;
                int curFactorial = 1;
                for (int i = 1; i <= currentNum; i++)
                {
                    curFactorial *= i;
                }
                factorialSum += curFactorial;

            }
            string result = factorialSum == num ? "yes" : "no";
            Console.WriteLine(result);

        }
    }
}
