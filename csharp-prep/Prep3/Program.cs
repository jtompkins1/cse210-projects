using System;

class Program
{
    static void Main(string[] args)
    {
        int guessInt = -1;

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,11);

        while (guessInt != magicNum)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessInt = int.Parse(guess);

            if (guessInt > magicNum)
            {
                Console.WriteLine("Lower ");
            }
        
            else if (guessInt < magicNum)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }

        }

    }
}