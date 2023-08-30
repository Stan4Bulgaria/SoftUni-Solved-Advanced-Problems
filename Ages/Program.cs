using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            string typeOfPerson = string.Empty;
            switch (age)
            {
                case int num when num <= 2:
                    typeOfPerson = "baby";
                    break;
                case int num when num > 2 && num<=13:
                    typeOfPerson = "child";
                    break;
                case int num when num >13 && num <=19:
                    typeOfPerson = "teenager";
                    break;
                case int num when num > 19 && num <= 65:
                    typeOfPerson = "adult";
                    break;
                default:
                    typeOfPerson = "elder";
                    break;

            }
            Console.WriteLine(typeOfPerson);
        }
    }
}
