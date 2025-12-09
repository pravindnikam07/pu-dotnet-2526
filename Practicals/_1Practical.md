# Introduction to .NET and C#

- Set up Visual Studio or Visual Studio Code for C# development and create a simple "Hello, World!" console application.
- Write a program to read user input and perform basic arithmetic operations (addition, subtraction, multiplication, division).
- Write a program that checks if a given number is prime and prints a confirmation message.

## Program 1: create a simple "Hello, World!" console application.

```cs
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Welcome to C# and .NET development in VS Code!");
    }
}
```

# Program 2: Write a program to read user input and perform basic arithmetic operations (addition, subtraction, multiplication, division).

```cs
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n------ Results ------");
        Console.WriteLine($"Addition: {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1 * num2}");

        Console.WriteLine(num2 == 0
            ? "Division: Cannot divide by ZERO!"
            : $"Division: {num1 / num2}");
    }
}
```

## Program 3: Write a program that checks if a given number is prime and prints a confirmation message.

```cs
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
            Console.WriteLine($"{number} is a Prime Number.");
        else
            Console.WriteLine($"{number} is NOT a Prime Number.");
    }

    static bool IsPrime(int num)
    {
        if (num <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
```
