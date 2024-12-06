using System;

namespace ObjectOrientedProgramming
{
    class ArrayAndMethodExercises
    {
        public static void RunArrayAndMethods()
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);
        }

        public static int[] GenerateNumbers(int length = 10)
        {
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = i + 1;
            }
            return numbers;
        }

        public static void Reverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }

        public static void PrintNumbers(int[] array)
        {
            Console.WriteLine("Array contents: " + string.Join(", ", array));
        }

        public static void RunFibonacciExample()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}");
            }
        }

        public static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}