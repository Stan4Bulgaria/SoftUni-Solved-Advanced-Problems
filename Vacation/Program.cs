using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var numPeople = int.Parse(Console.ReadLine());
            var TypeOfGroup = Console.ReadLine();
            var dayOfTheWeek = Console.ReadLine();
            double pricePerPerson = 0.0;
            var totalPrice = 0.0;
            switch (dayOfTheWeek)
            {
                case "Friday":
                    if (TypeOfGroup == "Students")
                        pricePerPerson = 8.45;

                    else if (TypeOfGroup == "Business")
                        pricePerPerson = 10.90;

                    else if (TypeOfGroup == "Regular")
                        pricePerPerson = 15;
                    break;

                case "Saturday":
                    if (TypeOfGroup == "Students")
                        pricePerPerson = 9.80;

                    else if (TypeOfGroup == "Business")
                        pricePerPerson = 15.60;

                    else if (TypeOfGroup == "Regular")
                        pricePerPerson = 20;
                    break;

                case "Sunday":
                    if (TypeOfGroup == "Students")
                        pricePerPerson = 10.46;

                    else if (TypeOfGroup == "Business")
                        pricePerPerson = 16;

                    else if (TypeOfGroup == "Regular")
                        pricePerPerson = 22.50;
                    break;
            }
            totalPrice = pricePerPerson * numPeople;
            if( TypeOfGroup == "Students" && numPeople >= 30)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if(TypeOfGroup == "Business" && numPeople >= 100)
            {
                totalPrice -= pricePerPerson * 10;
            }
            else if(TypeOfGroup == "Regular" && numPeople >=10 && numPeople <= 20)
            {
                totalPrice -= totalPrice * 0.05;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
