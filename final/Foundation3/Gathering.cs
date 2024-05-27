using System;

public class Gathering : Event
{
    protected string _type = "Gathering";
    public Gathering (string type, string title, string discription, string dateTime, Address address) : base(title, discription, dateTime, address, type)
    {
        //hmmmm
    }

    public override void DetailsLong()
    {
        base.DetailsLong();
        Console.WriteLine("The Weather Will be Sunny and 77F");
    }
}