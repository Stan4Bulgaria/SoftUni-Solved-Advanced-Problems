using System;
using System.Collections.Generic;
using System.Linq;

namespace Hero_recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroNameAndSpells = new Dictionary<string, List<string>>();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                if (command[0] == "Enroll")
                {
                    if (!heroNameAndSpells.ContainsKey(command[1]))
                    {
                        heroNameAndSpells.Add(command[1], new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} is already enrolled.");
                    }
                }
                else if (command[0] == "Learn")
                {
                    if (!heroNameAndSpells.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} doesn't exist.");
                        
                    }
                    else if (!heroNameAndSpells.Values.Any(x => x.Contains(command[2])))
                    {
                        heroNameAndSpells[command[1]].Add(command[2]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} has already learnt {command[2]}.");
                    }
                }
                else if (command[0] == "Unlearn")
                {
                    if (!heroNameAndSpells.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} doesn't exist.");
                        
                    }
                   else if(!heroNameAndSpells.Values.Any(x => x.Contains(command[2])))
                    {
                        Console.WriteLine($"{command[1]} doesn't know {command[2]}.");
                        
                    }
                    else
                    {
                        heroNameAndSpells[command[1]].Remove(command[2]);
                    }
                    
                    
                       
                    
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine("Heroes:");
            heroNameAndSpells = heroNameAndSpells.OrderByDescending(X => X.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in heroNameAndSpells)
            {
                Console.WriteLine($"== {item.Key}: {string.Join(", ", item.Value)}");
            }
        }
    }
}
