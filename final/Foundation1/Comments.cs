using System;

public class Comment
{
    private string _userName;
    private string _text;

    public Comment(string userName, string commentText)
    {
        _userName = userName;
        _text = commentText;
    }

    public void Display()
    {
        Console.WriteLine($"""
        UserName: {_userName}
        {_text}
        """);
    }
}