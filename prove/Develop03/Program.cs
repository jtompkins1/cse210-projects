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

        Scripture scripture = new Scripture(text, r1);

        Console.WriteLine(scripture);




    //     public string GetScripture()
    // {
    //     if (Reference._startVerse == Reference._endVerse)
    //     {
    //         string r = ($"{Reference._book} {Reference._chapter}: {_startVerse}");
    //         return r;
    //     }
    //     else
    //     {
    //         string r = ($"{Reference._book} {Reference._chapter}: {Reference._startVerse}-{Reference._endVerse}");
    //         return r;
    //     }
    // }
  

        // do
        // {

            

        // }while (userInput != "quit" || renderedText == isCompletelyHidden);


    }
}