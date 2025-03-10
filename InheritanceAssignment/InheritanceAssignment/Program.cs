using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Creating an instance of the Stack
        Stack stack = new Stack();

        // Pushing different data types onto the stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push("Hello");

        Console.WriteLine(stack.Pop()); // Output: Hello
        Console.WriteLine(stack.Pop()); // Output: 3
        Console.WriteLine(stack.Pop()); // Output: 2
        Console.WriteLine(stack.Pop()); // Output: 1

        // Check behavior when trying to pop from an empty stack
        try
        {
            stack.Pop(); // Should throw an exception
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }

        // Clearing the stack
        stack.Clear();
        Console.WriteLine("Stack cleared.");
    }
}

