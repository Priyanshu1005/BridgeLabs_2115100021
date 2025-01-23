using System;

class DayOfWeekCalculator
{
    static void Main(string[] args)
    {
        // Input: Month (m), Day (d), and Year (y)
        Console.Write("Enter month (1-12): ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter day (1-31): ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter year: ");
        int y = Convert.ToInt32(Console.ReadLine());

        // Step 1: Calculate y0
        int y0 = y - (14 - m) / 12;

        // Step 2: Calculate x
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;

        // Step 3: Calculate m0
        int m0 = m + 12 * ((14 - m) / 12) - 2;

        // Step 4: Calculate d0
        int d0 = (d + x + (31 * m0) / 12) % 7;

        // Output the day of the week
        Console.WriteLine($"The day of the week is: {d0}");
        Console.WriteLine("0: Sunday, 1: Monday, 2: Tuesday, 3: Wednesday, 4: Thursday, 5: Friday, 6: Saturday");
    }
}

