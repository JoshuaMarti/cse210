using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction first = new Fraction();
        Fraction second = new Fraction(6);
        Fraction third = new Fraction(6, 7);
        Console.WriteLine($"First fraction: {first.GetFractionString()}");
        Console.WriteLine($"Second fraction: {second.GetFractionString()}");
        Console.WriteLine($"Third fraction: {third.GetFractionString()}");
        Console.WriteLine($"Or a decimal: {third.GetDecimalValue()}");
    }
}