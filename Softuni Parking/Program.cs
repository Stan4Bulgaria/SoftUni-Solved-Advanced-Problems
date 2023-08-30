using System;
using System.Collections.Generic;

namespace _05._Softuni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> personAndLicensePlate = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] register = Console.ReadLine().Split();
                if (register[0] == "unregister" && personAndLicensePlate.ContainsKey(register[1]))
                {
                    Console.WriteLine($"{register[1]} unregistered successfully");
                    personAndLicensePlate.Remove(register[1]);
                    

                }
                else if ((!personAndLicensePlate.ContainsKey(register[1]) && register[0] == "unregister"))
                {
                    Console.WriteLine($"ERROR: user {register[1]} not found");
                    
                }
                else if (!personAndLicensePlate.ContainsKey(register[1]))
                {
                    personAndLicensePlate.Add(register[1], register[2]);
                    Console.WriteLine($"{register[1]} registered {register[2]} successfully");
                }
                else
                {
                    Console.WriteLine($"ERROR: already registered with plate number {register[2]}");
                }
                
            }
            foreach (var item in personAndLicensePlate)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
