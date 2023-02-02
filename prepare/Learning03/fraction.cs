using System;

//Create the Fraction class
public class Fraction
{
//    two attributes for the top and bottom numbers
    private int _top;
    private int _bottom;

    public Fraction()
    {
        //  initializes the number to 1/1.    
        _top = 1;
        _bottom = 1;
    }
    //  one parameter for the top and that initializes the denominator to 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        //two parameters, one for the top and one for the bottom
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        //Create a method called GetFractionString that returns the fraction in the form 3/4.
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        //Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75
        return (double)_top / (double)_bottom;
    }
}
