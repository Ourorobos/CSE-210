using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string dateTime, int minutes, int laps) : base(dateTime, minutes)
    {
        _laps = laps;
    }

    public override void Display()
    {
        Console.WriteLine(this.GetStringDisplay("Swimming", this.GetDistance(), this.GetSpeed()));
        Console.WriteLine(this.GetHours());
        Console.WriteLine(this.GetSpeed());
    }

    private double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    private double GetSpeed()
    {
        return this.GetDistance() / this.GetHours();
    }
}