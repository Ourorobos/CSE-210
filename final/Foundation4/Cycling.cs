using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string dateTime, int minutes, double speed) : base(dateTime, minutes)
    {
        _speed = speed;
    }

    public override void Display()
    {
        Console.WriteLine(this.GetStringDisplay("Cycling", this.GetDistance(), _speed));
    }

    private double GetDistance()
    {
        return _speed * this.GetHours();
    }
}