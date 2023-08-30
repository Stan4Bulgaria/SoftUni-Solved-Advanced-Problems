using System;

namespace GenericBoxOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine()); 

                box.Items.Add(input);

            }
            //    string[] swap = Console.ReadLine().Split();
            //    int firstIndex = int.Parse(swap[0]);
            //    int secondIndex = int.Parse(swap[1]);   
            //    box.Swap(firstIndex, secondIndex);
            //    Console.WriteLine(box.ToString());
            double inpute =double.Parse(Console.ReadLine());
            int number = box.CountGreaterThan(inpute);
            Console.WriteLine(number);
        }
    }
}
