using System;

namespace Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctPass = "";
            int incorrectCount = 0;
            for (int i = username.Length -1 ; i>=0; i--)
            {
                correctPass += username[i];
            }
            string password = Console.ReadLine();
            while (password != correctPass)
            {
                incorrectCount++;
                if (incorrectCount == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();

            }
            if (password == correctPass)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
