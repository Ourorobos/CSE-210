using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // constructors
    public Rectangle(double length, double width, string color) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Area functions
    public override double GetArea()
    {
        return _length * _width;
    }
}