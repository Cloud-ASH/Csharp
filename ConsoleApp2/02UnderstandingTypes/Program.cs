using System;

namespace _02UnderstandingTypes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Display data type sizes and ranges");
            Console.WriteLine("2. Convert centuries to other units");
            Console.WriteLine("3. FizzBuzz game");
            Console.WriteLine("4. Print a pyramid");
            Console.WriteLine("5. Number guessing game");
            Console.WriteLine("6. Calculate days from birthdate");
            Console.WriteLine("7. Greeting based on time");
            Console.WriteLine("8. Nested loop counter");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    UnderstandingTypes.DisplayNumberTypesInfo();
                    break;
                case 2:
                    CenturiesToOther.ConvertCenturies();
                    break;
                case 3:
                    FizzBuzz.Play();
                    break;
                case 4:
                    PyramidPrinter.PrintPyramid();
                    break;
                case 5:
                    NumberGuessGame.Play();
                    break;
                case 6:
                    BirthdayCalculator.Calculate();
                    break;
                case 7:
                    Greeting.SayHello();
                    break;
                case 8:
                    NestedLoopsCounter.PrintCounts();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}