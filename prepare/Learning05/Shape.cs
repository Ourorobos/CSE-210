using System;

public abstract class Shape
{
    private string _color;

    // constructor functions
    public Shape(string color)
    {
        _color = color;
    }

    // color funtions
    public string GetColor()
    {
        return _color;
    }

    //Area functions
    public abstract double GetArea();
}