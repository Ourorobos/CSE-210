using System;

public class Event
{
    private string _type;
    private string _title;
    private string _discription;
    private string _dateTime;
    private Address _address;

    public Event(string title, string discription, string dateTime, Address address, string type)
    {
        _title = title;
        _discription = discription;
        _dateTime = dateTime;
        _address = address;
        _type = type;
    }

    public void DetailsShort()
    {
        Console.WriteLine($"Event Type: {_type}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine(_dateTime);
    }
    public void DetailsMedium()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Discription: {_discription}");
        Console.WriteLine(_dateTime);
        Console.WriteLine(_address.GetAddress());
    }
    public virtual void DetailsLong()
    {
        Console.WriteLine($"Event Type: {_type}");
        this.DetailsMedium();
        Console.WriteLine("Detailes as follows:");
    }
}