using System;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment(string studentName, string topic, string textbookSelection, string problems) : base (studentName, topic)
    {
        // these two are automatically passed in
        // _studentName = studentName; 
        // _topic = topic;
        _textbookSection = textbookSelection;
        _problems = problems;

    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}