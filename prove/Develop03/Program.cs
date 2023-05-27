using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string userInput;

        // get Default scripture reference and text (Jacob 6:12)
        Scripture scripture = new Scripture();
        Console.WriteLine();
        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine();

        // Simple reference and text
        // Reference r1 = new Reference("John", 3, 16);
        // Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        // Console.WriteLine(s1.GetScripture());
        // Console.WriteLine();

        // Complex Reference and text
        // Reference r2 = new Reference("Matthew", 11, 28, 30);
        // Scripture s2= new Scripture(r2, "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.");
        // Console.WriteLine(s2.GetScripture());
        // Console.WriteLine();

        do
        {
            Console.WriteLine("Press enter to continue or 'quit' to finish: ");
            userInput = Console.ReadLine();
            Console.Clear();
            
            // Display rendered text
            scripture.SetHiddenScripture();
            Console.WriteLine(scripture.GetHiddenScripture());
 
        }while (userInput != "quit" || scripture.IsCompletelyHidden());

        Console.WriteLine("Thank you for using the Scripture Memorizer");

    }
}