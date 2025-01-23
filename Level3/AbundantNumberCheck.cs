using System;

class AbundantNumberCheck
{
    static void Main(string[] args)
    {
        // Step 1: Get an integer input from the user
        Console.Write("Enter a number to check if it's an Abundant Number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Step 2: Initialize sum variable to store the sum of divisors
        int sum = 0;

        // Step 3: Loop through potential divisors from 1 to number - 1
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0) // Check if i is a divisor
            {
                sum += i; // Add the divisor to the sum
            }
        }

        // Step 4: Check if the sum of divisors is greater than the number
        if (sum > number)
        {
            Console.WriteLine($"{number} is an Abundant Number.");
        }
        else
        {
            Console.WriteLine($"{number} is NOT an Abundant Number.");
        }
    }
}