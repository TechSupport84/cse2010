using System;
using System.Collections.Generic;


public class Video
{
    public string _title ;
    public string _author;
    public int _lengthInSeconds;
    private List<Comment>_comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
     
    }
    public void SetAddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}\n");

        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"{comment._commenterName}: {comment._textContent}");
        }

        Console.WriteLine();
    }
}
