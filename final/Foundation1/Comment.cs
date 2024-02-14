using System;

public class Comments
{
    private string _commentName;
    private string _commentText;


    // Constructor //
    public Comments(string name, string text)
    {
        _commentName = name;
        _commentText = text;
    }

    // Show the Comment Info //
    public void CommentInfo()
    {
        Console.WriteLine($"{_commentName}:");
        Console.WriteLine(_commentText);
    }
}