using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the size of the array
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        // Initialize the array
        int[] numbers = new int[size];

        // Prompt the user to enter the elements of the array
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Perform linear search for the first negative number
        int result = FindFirstNegative(numbers);

        // Display the result
        if (result != -1)
        {
            Console.WriteLine($"The first negative number is {numbers[result]} at index {result}.");
        }
        else
        {
            Console.WriteLine("No negative numbers found in the array.");
        }
    }

    static int FindFirstNegative(int[] array)
    {
        // Iterate through the array
        for (int i = 0; i < array.Length; i++)
        {
            // Check if the current element is negative
            if (array[i] < 0)
            {
                return i; // Return the index of the first negative number
            }
        }

        // If no negative number is found, return -1
        return -1;
    }
}