using System;

public class Video
{
    private string _title;
    private string _author;
    private int _timeSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lenghtSeconds)
    {
        _title = title;
        _author = author;
        _timeSeconds = lenghtSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title}: {_timeSeconds} Seconds, Author: {_author}, {this.GetCommentsCount()} Comments");
        this.DisplayComments();
    }

    private int GetCommentsCount()
    {
        return _comments.Count();
    }
    private void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}