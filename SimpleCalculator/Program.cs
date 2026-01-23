//Kyson Hensley
//RCET2265
//Spring 2026
//SimpleCalculator Program
//https://github.com/kysonhensley/SimpleCalculator.git

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0;
            int numberTwo = 0;
            string userInput = ""; 

            Console.WriteLine("Choose a  number:");
            numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose a number:");
            numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose one of the following options:");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Product");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
                    break;

                case "2": 
                    Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
                    break;

            }
            
            Console.Read();

        } 
    }
}
