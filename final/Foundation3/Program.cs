using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St.", "Rogers", "AR", "USA");
        Address address2 = new Address("2 Streetname", "Springfield", "MO", "USA");
        Address address3 = new Address("456 Block Ave.", "New City", "TX", "USA");

        Lecture lecture = new Lecture("Professor X", 50, "Telepathy for Beginners", "Learn telepathy from the professor", "Feb 1, 2023", "5:00pm", address1);
        Outdoor outdoor = new Outdoor("Sunny and hot", "Carnival", "The carnival is in town", "Aug 10, 2023", "11:00 AM", address2);
        Reception reception = new Reception("WeddingRSVP@gmail.com", "Jones Wedding", "Kyla and Solomon are getting married", "Oct 18, 2023", "4:00 PM", address3);

        //standard details
        Console.WriteLine("---Standard Details---");
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();

        //full details
        Console.WriteLine("---Full Details---");
        Console.WriteLine();
        lecture.DisplayFullDetails();
        Console.WriteLine();
        outdoor.DisplayFullDetails();
        Console.WriteLine();
        reception.DisplayFullDetails();
        Console.WriteLine();

        //short description
        Console.WriteLine("---Short Description---");
        Console.WriteLine();
        lecture.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayShortDescription();
        Console.WriteLine();

    }
}