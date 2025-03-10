using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {

        //Task 1: Check if Numbers Are Consecutive
        Console.Write("Enter numbers separated by hyphen: ");
        string input = Console.ReadLine();

        int[] numbers = input.Split('-').Select(int.Parse).ToArray();

        bool isIncreasing = true, isDecreasing = true;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] != numbers[i - 1] + 1)
                isIncreasing = false;
            if (numbers[i] != numbers[i - 1] - 1)
                isDecreasing = false;
        }

        Console.WriteLine(isIncreasing || isDecreasing ? "Consecutive" : "Not Consecutive");
        Console.WriteLine();

        //Task 2: Check for Duplicates
        Console.Write("Enter numbers separated by hyphen: ");
        string inp = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return; // Exit if input is empty

        int[] nums = input.Split('-').Select(int.Parse).ToArray();

        if (numbers.Length != numbers.Distinct().Count())
            Console.WriteLine("Duplicate");
        Console.WriteLine();

        //Task 3:  Validate 24-Hour Time Format
        Console.Write("Enter time in 24-hour format (HH:mm): ");
        string inpt = Console.ReadLine();

        if (TimeSpan.TryParse(input, out TimeSpan time) && time.Hours < 24 && time.Minutes < 60)
            Console.WriteLine("Ok");
        else
            Console.WriteLine("Invalid Time");
        Console.WriteLine();

        //Task 4: Convert Words to PascalCase 
        Console.Write("Enter words: ");
        string inpts = Console.ReadLine().ToLower();

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string pascalCase = string.Concat(textInfo.ToTitleCase(input).Split(' '));

        Console.WriteLine(pascalCase);
        Console.WriteLine();

        //Task 5: Count Vowels in a Word
        Console.Write("Enter a word: ");
        string inputs = Console.ReadLine().ToLower();

        int vowelCount = input.Count(c => "aeiou".Contains(c));
        Console.WriteLine($"Number of vowels: {vowelCount}");
    }
}

