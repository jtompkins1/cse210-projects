using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment a1 = new Assignment("A Name", "Math");
        Console.WriteLine(a1.GetSummary());

        MathAssignment m1 = new MathAssignment("Another Name", "Multiplication", "1", "9-16");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("More Names", "History", "WWII paper");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInfo());
    }

}