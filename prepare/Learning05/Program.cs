using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square(1, "Blue"));
        shapes.Add(new Square(5, "green"));

        shapes.Add(new Rectangle(1,1,"red"));
        shapes.Add(new Rectangle(2,5,"pink"));

        shapes.Add(new Circle(1,"Dark Blue"));
        shapes.Add(new Circle(10, "Help Me"));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea()} Color: {shape.GetColor()}");
        }
    }
}