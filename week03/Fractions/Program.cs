using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(0);
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);

        Console.WriteLine($"The fraction f1 is {f1.GetFractionString()}");
        Console.WriteLine($"The fraction f2 is {f2.GetFractionString()}");
        Console.WriteLine($"The fraction f3 is {f3.GetFractionString()}");

        Console.WriteLine($"The decimal value of f1 is {f1.GetDecimalValue()}");
        Console.WriteLine($"The decimal value of f2 is {f2.GetDecimalValue()}");
        Console.WriteLine($"The decimal value of f3 is {f3.GetDecimalValue()}");

        f3.SetTop(1);
        f3.SetBottom(3);
   
        Console.WriteLine($"The fraction f3 is now {f3.GetFractionString()}");
        Console.WriteLine($"The decimal value of f3 is now {f3.GetDecimalValue()}");


    }
}