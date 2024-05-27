using System;

public class Reception : Event
{
    protected string _type = "Reception";
    public Reception (string type, string title, string discription, string dateTime, Address address) : base(title, discription, dateTime, address, type)
    {
        //hmmmm
    }

    public override void DetailsLong()
    {
        base.DetailsLong();
        Console.WriteLine("To RSVP E-Mail: EventRSVP@Company.RSVP");
    }
}
