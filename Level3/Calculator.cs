
using System;

class Calculator
{
    static void Main(string[] args)
    {
        // Input: First number, second number, and operator
        Console.Write("Enter the first number: ");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double second = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /): ");
        string op = Console.ReadLine();

        // Perform calculation using switch...case
        switch (op)
        {
            case "+":
                Console.WriteLine($"Result: {first} + {second} = {first + second}");
                break;
            case "-":
                Console.WriteLine($"Result: {first} - {second} = {first - second}");
                break;
            case "*":
                Console.WriteLine($"Result: {first} * {second} = {first * second}");
                break;
            case "/":
                if (second != 0)
                {
                    Console.WriteLine($"Result: {first} / {second} = {first / second}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid operator. Please use one of the following: +, -, *, /");
                break;
        }
    }
}

