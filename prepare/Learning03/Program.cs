using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fractions program");

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6,7);

        int f1top = f1.GetTop();
        Console.WriteLine(f1top);
        int f1bottom = f1.GetBottom();
        Console.WriteLine(f1bottom);
        string f1Fraction = f1.GetFractionString();
        Console.WriteLine(f1Fraction);
        double f1decimal = f1.GetDecimalValue();
        Console.WriteLine(f1decimal);

        int f2top = f2.GetTop();
        Console.WriteLine(f2top);
        int f2bottom = f2.GetBottom();
        Console.WriteLine(f2bottom);
        string f2Fraction = f2.GetFractionString();
        Console.WriteLine(f2Fraction);
        double f2decimal = f2.GetDecimalValue();
        Console.WriteLine(f2decimal);       
       
        int f3top = f3.GetTop();
        Console.WriteLine(f3top);
        int f3bottom = f3.GetBottom();
        Console.WriteLine(f3bottom);
        string f3Fraction = f3.GetFractionString();
        Console.WriteLine(f3Fraction);
        double f3decimal = f3.GetDecimalValue();
        Console.WriteLine(f3decimal);
    }
}