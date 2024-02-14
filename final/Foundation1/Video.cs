using System;

public class Video
{
    private List<Comments> _listOfComments = new List<Comments>();

    private string _videoTitle;
    private string _videoAuthor;
    private int _videoLenght;


    // Constructor //
    public Video(string title, string author, int lenght)
    {
        _videoTitle = title;
        _videoAuthor = author;
        _videoLenght = lenght;
    }

    // Add Comment to this List //
    public void AddComment(Comments comment)
    {
        _listOfComments.Add(comment);
    }

    // Show the Video Info //
    public void VideoInfo()
    {
        Console.WriteLine($"Title: {_videoTitle} / Author: {_videoAuthor}");
        Console.WriteLine($"Total time: {_videoLenght} seconds");
        Console.WriteLine();

        int totalComments = _listOfComments.Count();
        Console.WriteLine($"Total Comments: {totalComments}");

        foreach (Comments comment in _listOfComments)
        {
            Console.WriteLine();
            comment.CommentInfo();
        }
    }
}