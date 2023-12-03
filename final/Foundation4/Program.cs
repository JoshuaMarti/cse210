using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        DateTime date = DateTime.Now;
        Console.WriteLine($"{date}");
        Thread.Sleep(2500);
        Console.WriteLine($"{date}");

    }
}