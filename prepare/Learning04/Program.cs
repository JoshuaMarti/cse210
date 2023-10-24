using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment newAssignment = new Assignment("Arthur Aardvark", "Artistic Expression");
        Console.WriteLine(newAssignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment("Michael Mathers", "Calculus", "7.2", "1-12");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        WritingAssignment writingAssignment = new WritingAssignment("Kiley Karuthers", "English", "Autonomous Advancement");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}