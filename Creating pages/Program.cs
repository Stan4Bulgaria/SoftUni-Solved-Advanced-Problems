using System;
using System.Collections.Generic;
using System.Linq;

namespace Creating_pages
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Enumerable.Range(0, 100).ToList();
            int page = int.Parse(Console.ReadLine()) -1 ;
            int count = 10;
            list = list.Skip(page * count).Take(count).ToList();
            Console.WriteLine(string.Join(" ", list));

        }
    }
}
