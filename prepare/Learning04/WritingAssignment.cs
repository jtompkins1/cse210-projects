using System;
public class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment(string studentName, string topic, string title): base (studentName, topic)
    {
        // these 2 not needed here
        // _studentName = studentName;
        // _topic = topic;
        _title = title;
    }
    public string GetWritingInfo()
    {
        // if I had not made protected
        // string studentName = GetStudentName():
        return $"{_title} by {_studentName}";
    }


}