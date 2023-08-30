using DifiningClasses;
using System;

namespace DefiningClasses
{
    public class StartUp
   {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] inpute = Console.ReadLine().Split();
                string name = inpute[0];
                int age = int.Parse(inpute[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }
            Person oldestFamily = family.GetOldestMember();
            Console.WriteLine($"{oldestFamily.Name} {oldestFamily.Age}");
        }
   }
}
