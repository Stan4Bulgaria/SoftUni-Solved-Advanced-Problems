using System;

namespace Vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpute = Console.ReadLine();
            double totalCoins = 0.0;
           
            double price = 0.0;
            string typeProduct = string.Empty;
            while(inpute != "Start")
            {
                double coins =double.Parse(inpute);
                if (!(coins == 1 || coins == 2 || coins == 0.50 || coins == 0.20 || coins == 0.10))
                {
                    Console.WriteLine($"Cannot accept {coins}");

                }
                else
                {
                    totalCoins += coins;
                }

                inpute = Console.ReadLine();
            }
            inpute = Console.ReadLine();
            price = 0.0;
            while (inpute != "End")
            {
                switch (inpute)
                {
                    case "Nuts":
                        typeProduct = "nuts";
                        price = 2.00;
                        break;
                    case "Water":
                        typeProduct = "water";
                        price = 0.70;
                        break;
                    case "Crisps":
                        typeProduct = "crisps";
                        price = 1.50;
                        break;
                    case "Soda":
                        typeProduct = "soda";
                        price = 0.80;
                        break;
                    case "Coke":
                        typeProduct = "coke";
                        price = 1.00;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                
                
                if(totalCoins >=price)
                {
                    if (price != 0)
                    {
                        totalCoins -= price;
                        Console.WriteLine($"Purchased {typeProduct}");
                    }
                  
                }
                else if(totalCoins < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                inpute = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalCoins:f2}");
        }
    }
}
