using System;
using System.Collections.Generic;

class FindMaxMin
{
    public static void FindLargestAndSmallest(List<int> numbers)
    {
        int max = numbers[0];
        int min = numbers[0];

        // Traversal method
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];
            if (numbers[i] < min)
                min = numbers[i];
        }

        Console.WriteLine($"Largest number is: {max}");
        Console.WriteLine($"Smallest number is: {min}");
    }
}
