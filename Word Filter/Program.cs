using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Trying_Dictionary_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> countryTown = new Dictionary<string, List<string>>();
            countryTown.Add("Bulgaria", new List<string>());
            countryTown.Add("Croatia", new List<string>());
            countryTown.Add("USA", new List<string>());
            countryTown.Add("AAA", new List<string>());

            countryTown["Bulgaria"].Add("Sofia");
            countryTown["Bulgaria"].Add("Plovdiv");
            countryTown["Bulgaria"].Add("Varna");

            countryTown["USA"].Add("New York");
            countryTown["USA"].Add("Angeles");
            countryTown["USA"].Add("Chikago");
            countryTown = countryTown.OrderBy(x => x.Value.Count).ToDictionary(x=>x.Key, x => x.Value);
            foreach (var country in countryTown)
            {
                Console.WriteLine($"{country.Key} => {string.Join(" ", country.Value)}");
            }



        }
    }
}
