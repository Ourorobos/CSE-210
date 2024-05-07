using System;

class Program
{
    static void Main(string[] args)
    {
        // testing constructors
        Fraction fraction = new Fraction();
        TestFraction(fraction);

        fraction = new Fraction(6);
        TestFraction(fraction);

        fraction = new Fraction(2,3);
        TestFraction(fraction);
    }

    static void TestFraction(Fraction fraction)
    {
        //testing get fuctions
        Console.WriteLine(fraction.GetTop());
        Console.WriteLine(fraction.GetBottom());
        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine(fraction.GetFractionValue());

        //testing set fuctions
        fraction.SetTop(5);
        fraction.SetBottom(10);
        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine(fraction.GetFractionValue());
    }
}