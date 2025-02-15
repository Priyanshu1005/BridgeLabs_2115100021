using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the size of the array
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        // Initialize the array
        int[] array = new int[size];

        // Prompt the user to enter the elements of the array
        Console.WriteLine("Enter the elements of the array (in rotated sorted order):");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Perform binary search to find the rotation point
        int rotationPoint = FindRotationPoint(array);

        // Display the result
        if (rotationPoint != -1)
        {
            Console.WriteLine($"The rotation point is at index {rotationPoint}.");
            Console.WriteLine($"The smallest element is {array[rotationPoint]}.");
        }
        else
        {
            Console.WriteLine("The array is not rotated or is empty.");
        }
    }

    static int FindRotationPoint(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        // If the array is not rotated, return the first element
        if (array[left] < array[right])
        {
            return 0;
        }

        // Perform binary search to find the rotation point
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if the mid element is the smallest
            if (mid > 0 && array[mid] < array[mid - 1])
            {
                return mid;
            }

            // Check if the mid element is greater than the last element
            if (array[mid] > array[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1; // If no rotation point is found
    }
}