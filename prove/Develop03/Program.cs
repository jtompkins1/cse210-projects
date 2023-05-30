using System;
using System.Collections.Generic;

// Attempt made to exceed exceed core requirements to select random words to hide from the remaining shown words.  See Scripture.cs lines 84-123.  

class Program
{
    static void Main(string[] args)
    {
        string _userInput;

        // get Default scripture reference and text (Jacob 6:12)
        // Scripture scripture = new Scripture();
        // Console.WriteLine();
        // Console.WriteLine(scripture.GetScripture());
        // Console.WriteLine();

        // Simple reference and text
        // Reference reference = new Reference("John", 3, 16);
        // Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        // Console.WriteLine();
        // Console.WriteLine(scripture.GetScripture());
        // Console.WriteLine();

        // Complex Reference and text
        Reference reference = new Reference("Matthew", 11, 28, 30);
        Scripture scripture = new Scripture(reference, "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.");
        Console.WriteLine();
        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine();

        do
        {
            Console.WriteLine("Press enter to continue or 'quit' to finish: ");
            _userInput = Console.ReadLine();
            Console.Clear();

            // Display rendered text
            scripture.SetHiddenScripture();
            Console.WriteLine(scripture.GetHiddenScripture());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                _userInput = "quit";
            }

        }while (_userInput != "quit");
        // || !scripture.IsCompletelyHidden());

        Console.Clear();
        Console.WriteLine("Thank you for using the Scripture Memorizer!");
        Console.WriteLine();

    }
}