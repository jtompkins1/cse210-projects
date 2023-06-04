using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        // countdown

        // for (int i = 5; i > 0; i--)
        // {
        //     Console.Write(i);
        //     Thread.Sleep(1000); // pause in miliseconds
        //     Console.Write("\b \b");
        // }

        // Animation Spinner |/-\|/-\|

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        // foreach (string s in animationStrings)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }



        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(20);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            // Console.Write(".");
            // Thread.Sleep(1000);
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }

        }




        // Thread.Sleep(3000); // pause in miliseconds


        // DateTime currentTime = DateTime.Now;
        // if (currentTime < endTime)
        // {
        //     Console.WriteLine("This paused for x seconds.");
        // }

        // if (currentTime < endTime)
        // {
        //     Console.Write("+");

        //     Thread.Sleep(500);

        //     Console.Write("\b \b"); // Erase the + character
        //     Console.Write("-"); // Replace it with the - character
        // }


    }
}