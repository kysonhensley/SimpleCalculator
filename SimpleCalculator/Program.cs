namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0;
            int numberTwo = 0;
            string userInput = 0; 

            Console.WriteLine("Choose a  number:");
            numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose a number:");
            numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose one of the following options:");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Product");
            Console.ReadLine();
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":

            }

        } 
    }
}
