using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percent = Console.ReadLine();
        int percentInt = int.Parse(percent);

        string letter;

        if (percentInt >= 97)
        {
            letter = "A";
        }
        else if (percentInt >= 90 && percentInt <= 93)
        {
            letter = "A-";
        }
        else if (percentInt >= 87)
        {
            letter = "B+";
        }
        else if (percentInt >= 80 && percentInt <= 83)
        {
            letter = "B-";
        }
        else if (percentInt >= 77)
        {
            letter = "C+";
        }
          else if (percentInt >= 70 && percentInt <= 73)
        {
            letter = "C-";
        }
        else if (percentInt >= 67)
        {
            letter = "D+";
        }
          else if (percentInt >= 60 && percentInt <= 63)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}. ");

        if (percentInt >= 70)
        {
            Console.WriteLine("Congratulations, you passed! ");
        }
        else
        {
            Console.WriteLine("That's okay, you'll do better next time! ");
        }

    }
}