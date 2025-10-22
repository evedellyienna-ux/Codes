using System;
using System.Collections.Generic;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> numbers = new List<int>();

      Console.Write("Enter 1st number: ");
      numbers.Add(Convert.ToInt32(Console.ReadLine()));
      Console.Write("Enter 2nd number: ");
      numbers.Add(Convert.ToInt32(Console.ReadLine()));
      Console.Write("Enter 3rd number: ");
      numbers.Add(Convert.ToInt32(Console.ReadLine()));
      Console.Write("Enter 4th number: ");
      numbers.Add(Convert.ToInt32(Console.ReadLine()));
      Console.Write("Enter 5th number: ");
      numbers.Add(Convert.ToInt32(Console.ReadLine()));

      string results = String.Join(", ", numbers);
      Console.WriteLine("Here are your numbers: " + results);

      // call the function from the other file
      FindMaxMin.FindLargestAndSmallest(numbers);
    }
  }
}
