using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string userInput;

        // string renderedText;
        // bool isCompletelyHidden;
        
        // Complex Reference
        // Reference r1 = new Reference();
        // Scripture s1 = new Scripture(r1);
        // Console.WriteLine(s1.GetScripture());

        // Simple reference
        // Reference r2 = new Reference("John", 3, 16);
        // Scripture s2 = new Scripture(r2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        // Console.WriteLine(s2.GetScripture());

        // get default scripture reference and text
        Scripture scripture = new Scripture();
        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine();

        do
        {
            Console.WriteLine("Press enter to continue or 'quit' to finish: ");
            userInput = Console.ReadLine();
            Console.Clear();
            // Display rendered text
            scripture.SetHiddenScripture();
            Console.WriteLine(scripture.GetHiddenScripture());


        }while (userInput != "quit");
        // }while (userInput != "quit" || renderedText == isCompletelyHidden);

        Console.WriteLine("Thank you for using the Scripture Memorizer");

    }
}