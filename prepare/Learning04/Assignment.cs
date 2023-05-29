using System;

public class Assignment
{

    protected string _studentName = "";
    protected string _topic = "";

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Instead of changing attributes to protected I could have done...

    // We will provide Getters for our private member variables so they can be accessed
    // later both outside the class as well is in derived classes.
    // public string GetStudentName()
    // {
    //     return _studentName;
    // }

    // public string GetTopic()
    // {
    //     return _topic;
    // }
}