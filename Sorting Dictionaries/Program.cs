using System;
using System.Collections.Generic;

namespace Sorting_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> userAges = new SortedDictionary<int, string>();
            userAges[1] = "Pesho";
            userAges[2] = "Mistafa";
            userAges[3] = "Arsen";
            userAges[4] = "Gavril";
            userAges[5] = "Dobi";
            foreach (var item in userAges)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
