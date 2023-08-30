using System;
using System.Text.RegularExpressions;

namespace Message_translater
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Regex ways = new Regex(@"\!([A-Z][a-z]{2,})\!\:\[([a-zA-z]{8,})\]");

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                Match match = ways.Match(input);

                if (match.Success)
                {
                    string name = match.Groups[2].ToString();
                    string nums = string.Empty;
                    for (int j = 0; j < name.Length; j++)
                    {
                        int digit = name[j];
                        nums += digit + " ";

                    }
                    Console.WriteLine($"{match.Groups[1]}: {nums}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
