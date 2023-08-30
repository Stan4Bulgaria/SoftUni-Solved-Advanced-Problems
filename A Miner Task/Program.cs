using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfMetal = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Dictionary<string, int> metalAndQuantity = new Dictionary<string, int>();
            while(typeOfMetal != "stop")
            {
                if (!metalAndQuantity.ContainsKey(typeOfMetal))
                {
                    metalAndQuantity.Add(typeOfMetal, quantity);
                }
                else
                {
                    metalAndQuantity[typeOfMetal] += quantity;
                }
                typeOfMetal = Console.ReadLine();
                if(typeOfMetal == "stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
            }
            foreach (var item in metalAndQuantity)
            {
                Console.Write($"\n{item.Key} -> {item.Value}");
            }
        }
    }
}
