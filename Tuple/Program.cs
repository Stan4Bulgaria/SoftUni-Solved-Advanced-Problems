using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            string infoOfPerson = string.Join(" ", input[0], input[1]);
            string cityInfo = input[3];
            if (input.Length == 5)
            {
                cityInfo = string.Join(" ", input[3], input[4]);
            }
            
            MyTuple<string, string, string> personInfo = new MyTuple<string, string, string>
                (infoOfPerson, input[2],  cityInfo);

            input = Console.ReadLine().Split();
            bool drunkOrNot = false;
            if (input[2] == "drunk")
            {
                drunkOrNot = true;
            }
            MyTuple<string, int, bool> markInfo = new MyTuple<string, int, bool>
                (input[0], int.Parse(input[1]), drunkOrNot);

            input = Console.ReadLine().Split();
            MyTuple<string, double, string> doubleInfo = new MyTuple<string, double, string>
                (input[0], double.Parse(input[1]), input[2]);

            Console.WriteLine(personInfo.ToString());
            Console.WriteLine(markInfo.ToString());
            Console.WriteLine(doubleInfo.ToString());

        }
    }
}
