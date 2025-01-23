
using System;

class HarshadNumberCheck
{
    static void Main(string[] args)
    {
        // Step 1: Get an integer input from the user
        Console.Write("Enter a number to check if it's a Harshad Number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Step 2: Create variables to store the original number and the sum of its digits
        int originalNumber = number; // Keep the original number for final comparison
        int sum = 0;

        // Step 3: Loop to calculate the sum of digits of the number
        while (number != 0)
        {
            int digit = number % 10; // Extract the last digit
            sum += digit;           // Add the digit to the sum
            number /= 10;           // Remove the last digit
        }

        // Step 4: Check if the original number is divisible by the sum of its digits
        if (originalNumber % sum == 0)
        {
            Console.WriteLine($"{originalNumber} is a Harshad Number.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is NOT a Harshad Number.");
        }
    }
}

