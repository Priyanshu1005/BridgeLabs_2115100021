
using System;

class DigitCounter
{
    static void Main(string[] args)
    {
        // Step 1: Get integer input from the user
        Console.Write("Enter an integer to count its digits: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Step 2: Initialize count variable to 0
        int count = 0;

        // Handle negative numbers by converting them to positive
        if (number < 0)
        {
            number = Math.Abs(number);
        }

        // Special case for 0
        if (number == 0)
        {
            count = 1;
        }
        else
        {
            // Step 3: Loop until the number becomes 0
            while (number != 0)
            {
                // Remove the last digit
                number /= 10;

                // Increment the count
                count++;
            }
        }

        // Step 4: Display the count
        Console.WriteLine($"The number of digits is: {count}");
    }
}

