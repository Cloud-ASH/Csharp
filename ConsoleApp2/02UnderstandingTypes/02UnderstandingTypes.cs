namespace _02UnderstandingTypes
{
    class UnderstandingTypes
    {
        public static void DisplayNumberTypesInfo()
        {
            Console.WriteLine($"sbyte: Size = {sizeof(sbyte)} bytes, Range = {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"byte: Size = {sizeof(byte)} bytes, Range = {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"short: Size = {sizeof(short)} bytes, Range = {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"ushort: Size = {sizeof(ushort)} bytes, Range = {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"int: Size = {sizeof(int)} bytes, Range = {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"uint: Size = {sizeof(uint)} bytes, Range = {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"long: Size = {sizeof(long)} bytes, Range = {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"ulong: Size = {sizeof(ulong)} bytes, Range = {ulong.MinValue} to {ulong.MaxValue}");
            Console.WriteLine($"float: Size = {sizeof(float)} bytes, Range = {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"double: Size = {sizeof(double)} bytes, Range = {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"decimal: Size = {sizeof(decimal)} bytes, Range = {decimal.MinValue} to {decimal.MaxValue}");
        }
    }

    class CenturiesToOther
    {
        public static void ConvertCenturies()
        {
            Console.Write("Enter centuries: ");
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            long days = years * 36524L / 100; // Adjusting for leap years
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            ulong nanoseconds = (ulong)microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
    
    class FizzBuzz
    {
        public static void Play()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
    
    class PyramidPrinter
    {
        public static void PrintPyramid()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(new string(' ', 5 - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
        }
    }
    
    class NumberGuessGame
    {
        public static void Play()
        {
            int correctNumber = new Random().Next(1, 4);
            Console.WriteLine("Guess a number between 1 and 3:");

            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber < 1 || guessedNumber > 3)
                Console.WriteLine("Out of range!");
            else if (guessedNumber < correctNumber)
                Console.WriteLine("Too low!");
            else if (guessedNumber > correctNumber)
                Console.WriteLine("Too high!");
            else
                Console.WriteLine("Correct!");
        }
    }
    
    class BirthdayCalculator
    {
        public static void Calculate()
        {
            Console.Write("Enter your birth date (yyyy-mm-dd): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;

            int daysOld = (today - birthDate).Days;
            Console.WriteLine($"You are {daysOld} days old.");

            int daysToNextAnniversary = 10000 - (daysOld % 10000);
            Console.WriteLine($"Your next 10,000-day anniversary is in {daysToNextAnniversary} days.");
        }
    }
    
    class Greeting
    {
        public static void SayHello()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 5 && hour < 12)
                Console.WriteLine("Good Morning");
            if (hour >= 12 && hour < 17)
                Console.WriteLine("Good Afternoon");
            if (hour >= 17 && hour < 21)
                Console.WriteLine("Good Evening");
            if (hour >= 21 || hour < 5)
                Console.WriteLine("Good Night");
        }
    }
    
    class NestedLoopsCounter
    {
        public static void PrintCounts()
        {
            for (int outer = 1; outer <= 4; outer++)
            {
                for (int inner = 0; inner <= 24; inner += outer)
                {
                    Console.Write(inner + (inner < 24 ? ", " : "\n"));
                }
            }
        }
    }
}
