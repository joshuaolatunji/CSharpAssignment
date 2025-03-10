using System;
using System.Linq; // Add this to use LINQ methods like Select and Max

//Task 1:Count Numbers Divisible by 3 (Between 1 and 100)
int count = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
        count++;
}

Console.WriteLine("Count of numbers divisible by 3: " + count);
Console.WriteLine();

//Task 2: Sum of Numbers Until "ok" is Entered
int sum = 0;

while (true)
{
    Console.Write("Enter a number or type 'ok' to exit: ");
    string input = Console.ReadLine(); // Renamed variable to 'input' to avoid conflict

    if (input == null) // Check for null input to avoid CS8600
        continue;

    if (input.ToLower() == "ok")
        break;

    sum += Convert.ToInt32(input);
}

Console.WriteLine("Total sum: " + sum);
Console.WriteLine();


//Task 3: Compute Factorial of a Number
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = 1;

for (int i = number; i > 0; i--)
{
    factorial *= i;
}

Console.WriteLine(number + "! = " + factorial);


//Task 4: Random Number Guessing Game (1-10, 4 Attempts)
Random random = new Random();
int secretNumber = random.Next(1, 11); // Generates a number between 1 and 10

// For debugging: Console.WriteLine("Secret Number: " + secretNumber);

int attempts = 4;

for (int i = 0; i < attempts; i++)
{
    Console.Write("Guess the number (1-10): ");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess == secretNumber)
    {
        Console.WriteLine("You won!");
        return;
    }
}

Console.WriteLine("You lost! The correct number was: " + secretNumber);
Console.WriteLine();


//Task 5: Find Maximum Number in a Comma-Separated List
Console.Write("Enter numbers separated by commas: ");
string inputNumbers = Console.ReadLine();

if (inputNumbers != null) // Check for null input to avoid CS8600
{
    int[] numbers = inputNumbers.Split(',').Select(n => Convert.ToInt32(n.Trim())).ToArray();
    int max = numbers.Max();

    Console.WriteLine("The maximum number is: " + max);
}
