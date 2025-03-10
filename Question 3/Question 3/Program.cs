using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        //Task 1: Facebook Likes Display
        List<string> names = new List<string>();

        while (true)
        {
            Console.Write("Enter a name (or press Enter to finish): ");
            string n = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(n))
                break;

            names.Add(n);
        }

        if (names.Count == 1)
            Console.WriteLine($"{names[0]} likes your post.");
        else if (names.Count == 2)
            Console.WriteLine($"{names[0]} and {names[1]} like your post.");
        else if (names.Count > 2)
            Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
        Console.WriteLine();    


        //Task 2: Reverse a Name 
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        char[] charArray = name.ToCharArray();
        Array.Reverse(charArray);
        string reversedName = new string(charArray);

        Console.WriteLine("Reversed name: " + reversedName);
        Console.WriteLine();


        //Task 3: Unique 5 Numbers Sorted
        HashSet<int> numbers = new HashSet<int>();

        while (numbers.Count < 5)
        {
            Console.Write($"Enter a unique number ({numbers.Count + 1}/5): ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (numbers.Contains(number))
                Console.WriteLine("Error: You have already entered this number. Try again.");
            else
                numbers.Add(number);
        }

        List<int> sortedNumbers = numbers.ToList();
        sortedNumbers.Sort();

        Console.WriteLine("Sorted numbers: " + string.Join(", ", sortedNumbers));
        Console.WriteLine();


        //Task 4: Display Unique Numbers from Input
        HashSet<int> uniqueNumbers = new HashSet<int>();

        while (true)
        {
            Console.Write("Enter a number (or type 'Quit' to stop): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            int number = Convert.ToInt32(input);
            uniqueNumbers.Add(number);
        }

        Console.WriteLine("Unique numbers: " + string.Join(", ", uniqueNumbers));
        Console.WriteLine();


        //Task 5: Find the 3 Smallest Numbers from a List
        while (true)
        {
            Console.Write("Enter at least 5 numbers separated by commas: ");
            string input = Console.ReadLine();

            int[] nums = input.Split(',').Select(n => Convert.ToInt32(n.Trim())).ToArray();

            if (nums.Length < 5)
            {
                Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                continue;
            }

            Array.Sort(nums);

            Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", numbers.Take(3)));
            break;
        }
        Console.WriteLine();

    }
}

