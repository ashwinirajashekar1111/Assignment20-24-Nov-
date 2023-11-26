using System;

class Program
{
    static void Main()
    {
        // Task 1: Hello World
        Console.WriteLine("Task 1: Hello World");
        Console.WriteLine("Hello, World!");
        Console.WriteLine();

        // Task 2: Variables and User Input
        Console.WriteLine("Task 2: Variables and User Input");
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}!");
        Console.WriteLine();

        // Task 3: Basic Arithmetic
        Console.WriteLine("Task 3: Basic Arithmetic");
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sum: {num1 + num2}");
        Console.WriteLine($"Difference: {num1 - num2}");
        Console.WriteLine($"Product: {num1 * num2}");

        if (num2 != 0)
            Console.WriteLine($"Quotient: {num1 / (double)num2}"); // Handle division by zero
        else
            Console.WriteLine("Cannot divide by zero.");

        Console.WriteLine($"Remainder: {num1 % num2}");
        Console.WriteLine();

        // Task 4: Control Structures
        Console.WriteLine("Task 4: Control Structures");
        Console.Write("Enter an integer: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        if (userNumber % 2 == 0)
            Console.WriteLine($"{userNumber} is even.");
        else
            Console.WriteLine($"{userNumber} is odd.");
        Console.WriteLine();

        // Task 5: Loops
        Console.WriteLine("Task 5: Loops");
        Console.WriteLine("Numbers from 1 to 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        // Task 6: Arrays
        Console.WriteLine("Task 6: Arrays");
        int[] numbersArray = { 2, 4, 6, 8, 10 };
        int sum = 0;

        foreach (int num in numbersArray)
        {
            sum += num;
        }

        double average = (double)sum / numbersArray.Length;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine();

        // Task 7: Methods
        Console.WriteLine("Task 7: Methods");
        Console.Write("Enter a positive integer: ");
        int userInteger = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Factorial of {userInteger}: {CalculateFactorial(userInteger)}");
        Console.WriteLine();

        // Task 8: Exception Handling
        Console.WriteLine("Task 8: Exception Handling");
        int age;

        do
        {
            Console.Write("Enter your age: ");
            string inputAge = Console.ReadLine();

            if (int.TryParse(inputAge, out age))
            {
                if (age < 18)
                    Console.WriteLine("You are a minor.");
                else if (age >= 18 && age <= 65)
                    Console.WriteLine("You are an adult.");
                else
                    Console.WriteLine("You are a senior.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        } while (age <= 0); 

        Console.ReadLine(); 
    }

    // Task 7: Methods - CalculateFactorial method
    static int CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
}

