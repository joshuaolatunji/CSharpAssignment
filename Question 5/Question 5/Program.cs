using System;
using System.IO;

class Program
{
    static void Main()
    {

        //Task 1: Count the Number of Words in a Text File
        string filePath = "sample.txt"; // Change this to your actual file path

        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Number of words in the file: " + words.Length);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
        Console.WriteLine();

        //Task 2: Find the Longest Word in a Text File

        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();
            Console.WriteLine("Longest word in the file: " + longestWord);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
        Console.WriteLine();
    }
}
