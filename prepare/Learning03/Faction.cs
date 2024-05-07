using System;

class Fraction
{
    int _numerator;
    int _denominator;

    //Constructors
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }
    public Fraction(int top, int botttom)
    {
        _numerator = top;
        _denominator = botttom;
    }

    // Set Functions
    public void SetTop(int newTop)
    {
        _numerator = newTop;
    }
    public void SetBottom(int newBottom)
    {
        _denominator = newBottom;
    }

    // Get Functions
    public int GetTop()
    {
        return _numerator;
    }

    public int GetBottom()
    {
        return _denominator;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }

    public string GetFractionValue()
    {
        return $"{_numerator}/{_denominator}";
    }
}