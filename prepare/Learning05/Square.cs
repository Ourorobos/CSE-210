using System;

public class Square : Shape
{
    private double _side;

    // Constructor function
    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    // Area functions
    public override double GetArea()
    {
        return _side * _side;
    }
}