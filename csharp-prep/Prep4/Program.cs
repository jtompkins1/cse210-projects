using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter Number: ");
            string entry = Console.ReadLine();
            number = int.Parse(entry);

            if (number != 0)
            {
                numbers.Add(number);
            }

        }

        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }

        Console.WriteLine($"The sum is: {total}");
        int listSize = numbers.Count;

        int average = total / listSize;
        Console.WriteLine($"The average is: {average}");

        int max = 0;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The highest number is: {max}");


        
    }
}