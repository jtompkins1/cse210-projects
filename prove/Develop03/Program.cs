using System;

class Program
{
    static void Main(string[] args)
    {
        // string userInput;
        // string renderedText;
        // bool isCompletelyHidden;
        
        string text = "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.";
        Reference r1 = new Reference("Matthew", 11, 28, 30);

        Scripture scripture = new Scripture(r1, text);
        Console.WriteLine(scripture.GetScripture());


        // do
        // {

            

        // }while (userInput != "quit" || renderedText == isCompletelyHidden);


    }
}