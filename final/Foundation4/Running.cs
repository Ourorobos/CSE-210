using System;

public class Running : Activity
{
    private double _distance;

    public Running(string dateTime, int minutes, double distance) : base(dateTime, minutes)
    {
        _distance = distance;
    }

    public override void Display()
    {
        Console.WriteLine(this.GetStringDisplay("Running", _distance, this.GetSpeed()));
    }

    private double GetSpeed()
    {
        return _distance / this.GetHours();
    }
}