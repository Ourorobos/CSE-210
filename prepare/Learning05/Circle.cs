using System;

public class Circle : Shape
{
    private double _radius;

    // constructor function
    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    // area function
    public override double GetArea()
    {
        return 3.14159 * (_radius * _radius);
    }
}