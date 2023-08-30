using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryItems = new Dictionary<string, int>();
            legendaryItems.Add("shards", 0);
            legendaryItems.Add("fragments", 0);
            legendaryItems.Add("motes", 0);
            Dictionary<string, int> junkItems = new Dictionary<string, int>();
            bool isFound = false;
            while (!isFound)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 1; i < input.Length; i += 2)
                {
                    string matireal = input[i].ToLower();
                    int quantity = int.Parse(input[i - 1]);
                    if (matireal == "shards" || matireal == "fragments" || matireal == "motes")
                    {
                        legendaryItems[matireal] += quantity;
                        if (legendaryItems[matireal] >= 250)
                        {
                            isFound = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkItems.ContainsKey(matireal))
                        {
                            junkItems.Add(matireal, quantity);
                        }
                        else
                        {
                            junkItems[matireal] += quantity;
                        }
                    }
                }
            }
            if (legendaryItems["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                legendaryItems["shards"] -= 250;
            }
            else if (legendaryItems["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                legendaryItems["fragments"] -= 250;
            }
            else if (legendaryItems["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                legendaryItems["motes"] -= 250;
            }
            foreach (var item in legendaryItems.OrderByDescending(x => x.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkItems.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }

    }
}            