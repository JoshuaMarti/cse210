using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        DateTime date = DateTime.Now;
        Console.WriteLine($"{date}");
        Thread.Sleep(2500);
        date = DateTime.Now;
        Console.WriteLine($"{date}");
    }
}