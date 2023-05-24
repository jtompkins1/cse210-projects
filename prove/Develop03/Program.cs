using System;

class Program
{
    static void Main(string[] args)
    {
        // string userInput;
        // string renderedText;
        // bool isCompletelyHidden;
        
        // string text = "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.";
        Reference r1 = new Reference();
        Scripture s1 = new Scripture(r1);
        Console.WriteLine(s1.GetScripture());
        Console.WriteLine();

        Reference r2 = new Reference("John", 3, 16);
        Scripture s2 = new Scripture(r2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Console.WriteLine(s2.GetScripture());
        Console.WriteLine();

        Scripture s3 = new Scripture();
        Console.WriteLine(s3.GetScripture());



        // do
        // {

            

        // }while (userInput != "quit" || renderedText == isCompletelyHidden);


    }
}