using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture (string type, string title, string discription, string dateTime, Address address, string speaker, int capacity) : base(title, discription, dateTime, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void DetailsLong()
    {
        base.DetailsLong();
        Console.WriteLine(_speaker);
        Console.WriteLine(_capacity);
    }
}