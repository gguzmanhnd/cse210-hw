// Gerardo Guzman - 2026 - CES
using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
       _top = 1;
      _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

     public void SetTop(int top)
    {
        if (top!= 0)
        {
            _top = top;
        }
        else
        {throw new ArgumentException("Numerator cannot be zero.");}
        
    }
    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {throw new ArgumentException("Denominator cannot be zero.");}
        
    }
    
   




    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
   
}