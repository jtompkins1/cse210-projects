using System;
using System.Collections.Generic;


public class Video
{
    public string _title;
    public string _author;
    public int _seconds;
    public List<Comment> _comments = new List<Comment>();

    public int GetCommentCount()
    {
        return _comments.Count();
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length: {_seconds} seconds, Number of Comments: {GetCommentCount()}.");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}


  