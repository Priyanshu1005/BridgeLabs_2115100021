using System;

class ArmstrongNumberChecker
{
    static void Main(string[] args)
    {
        // Step 1: Get integer input from the user
        Console.Write("Enter a number to check if it is an Armstrong number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Step 2: Initialize sum to 0 and assign input to originalNumber
        int originalNumber = number;
        int sum = 0;

        // Step 3: Use a while loop to calculate the sum of cubes of each digit
        while (originalNumber != 0)
        {
            // Step 4: Find the remainder (last digit) using modulus operator
            int digit = originalNumber % 10;

            // Step 5: Cube the digit and add it to the sum
            sum += digit * digit * digit;

            // Step 6: Remove the last digit by dividing by 10
            originalNumber /= 10;
        }

        // Step 7: Check if the sum equals the original number
        if (sum == number)
        {
            Console.WriteLine($"The number {number} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"The number {number} is not an Armstrong number.");
        }
    }
}