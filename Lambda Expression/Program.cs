using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
                { 1,2,3,4,5,6,7,8,9,10};
            list = list.Where(x => x % 2 == 0).ToList();
            Console.WriteLine(string.Join(" ", list));
            List<int> list2 = new List<int>()
                { 1,2,3,4,5,6,7,8,9,10};
            list2 = list2.Where(x => x % 2 != 0).ToList();
            Console.WriteLine(string.Join(" ", list2));
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            array = array.Where(x => x !=0 ).ToArray();
            Console.WriteLine(string.Join(" ", array));


            //List<int> list = new List<int>()
            //{ 1,2,3,4,5,6,7,8,9,10};
            //list = list.Where(isEven).ToList();
            //Console.WriteLine(string.Join(" ", list));
        }
        
    }
}
