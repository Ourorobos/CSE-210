using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Activity
{
    private string _dateTime;
    private int _minutes;

    public Activity(string dateTime, int minutes)
    {
        _dateTime = dateTime;
        _minutes = minutes;
    }

    public virtual void Display()
    {
        //Override
    }

    public string GetStringDisplay(string activity, double distance, double speed)
    {
        return $"{_dateTime} {activity} ({_minutes})- Distance {distance} miles, Speed {speed} Mph, Pace {this.GetPace(distance)} Min per Mile";
    }
    public double GetHours()
    {
        return _minutes / 60;
    }

    private double GetPace(double distance)
    {
        return _minutes / distance;
    }
}