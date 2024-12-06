using System;
using System.Collections.Generic;

namespace ArrayAndStringExercises
{
    class ArrayAndStringExercises
    {
        // Function 1: Copy an array
        public static void CopyArray()
        {
            int[] original = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] copy = new int[original.Length];

            for (int i = 0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }

            Console.WriteLine("Original array: " + string.Join(", ", original));
            Console.WriteLine("Copied array: " + string.Join(", ", copy));
        }

        // Function 2: Manage a list (Add, Remove, Clear)
        public static void ManageList()
        {
            List<string> items = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
                string command = Console.ReadLine();

                if (command.StartsWith("+"))
                {
                    items.Add(command.Substring(1).Trim());
                }
                else if (command.StartsWith("-"))
                {
                    items.Remove(command.Substring(1).Trim());
                }
                else if (command == "--")
                {
                    items.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }

                Console.WriteLine("Current list: " + string.Join(", ", items));
            }
        }

        // Function 3: Find primes in a given range
        public static void FindPrimesInRange()
        {
            Console.Write("Enter start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            int end = int.Parse(Console.ReadLine());

            List<int> primes = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i)) primes.Add(i);
            }

            Console.WriteLine("Primes in range: " + string.Join(", ", primes));
        }

        private static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        // Function 4: Rotate an array and sum it
        public static void RotateAndSumArrays()
        {
            Console.WriteLine("Enter array (space-separated):");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine("Enter number of rotations:");
            int k = int.Parse(Console.ReadLine());

            int[] sum = new int[arr.Length];
            for (int r = 0; r < k; r++)
            {
                int last = arr[^1]; // Get last element
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = last;

                for (int i = 0; i < arr.Length; i++)
                {
                    sum[i] += arr[i];
                }
            }

            Console.WriteLine("Sum array: " + string.Join(", ", sum));
        }

        // Function 5: Find the longest sequence of equal elements
        public static void FindLongestSequence()
        {
            Console.WriteLine("Enter array (space-separated):");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int maxLength = 1, currentLength = 1, bestStart = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        bestStart = i - currentLength + 1;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }

            Console.WriteLine("Longest sequence: " + string.Join(" ", arr[bestStart..(bestStart + maxLength)]));
        }

        // Function 6: Find the most frequent number
        public static void FindMostFrequentNumber()
        {
            Console.WriteLine("Enter array (space-separated):");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (var num in arr)
            {
                if (!freq.ContainsKey(num))
                    freq[num] = 0;
                freq[num]++;
            }

            int maxCount = 0, mostFrequent = arr[0];
            foreach (var kvp in freq)
            {
                if (kvp.Value > maxCount)
                {
                    maxCount = kvp.Value;
                    mostFrequent = kvp.Key;
                }
            }

            Console.WriteLine($"Most frequent number: {mostFrequent} (occurs {maxCount} times)");
        }

        // Function 7: Reverse a string
        public static void ReverseString()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("Reversed string: " + new string(charArray));
        }

        // Function 8: Parse a URL
        public static void ParseURL()
        {
            Console.Write("Enter a URL: ");
            string url = Console.ReadLine();

            var protocolEndIndex = url.IndexOf("://");
            string protocol = protocolEndIndex > 0 ? url.Substring(0, protocolEndIndex) : "";

            var serverStartIndex = protocolEndIndex > 0 ? protocolEndIndex + 3 : 0;
            var serverEndIndex = url.IndexOf("/", serverStartIndex);
            string server = serverEndIndex > 0 ? url.Substring(serverStartIndex, serverEndIndex - serverStartIndex) : url.Substring(serverStartIndex);

            string resource = serverEndIndex > 0 ? url.Substring(serverEndIndex + 1) : "";

            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
        }
    }
}
