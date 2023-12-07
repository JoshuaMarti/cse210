using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");
        //Running
        Running running = new Running("20231207", 11.4, 1.04);
        Console.WriteLine(running.GetSummary());
        //Cycling
        Cycling cycling = new Cycling("20220427", 35.7,  9.33);
        Console.WriteLine(cycling.GetSummary());
        //Swimming
        Swimming swimming = new Swimming("20230902", 5, 4);
        Console.WriteLine(swimming.GetSummary());

    }
}