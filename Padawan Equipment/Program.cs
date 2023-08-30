using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            //double lighSaberPrice = double.Parse(Console.ReadLine());
           // double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
           // lighSaberPrice = lighSaberPrice * (countOfStudents +(Math.Ceiling(countOfStudents * 0.10)));
            //robePrice = robePrice * countOfStudents;
            if(countOfStudents % 6 == 0)
            {
                 
                
            }
            else
            {
                beltPrice = beltPrice * countOfStudents;
            }
            
            

        }
    }
}
