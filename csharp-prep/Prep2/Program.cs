using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!");
        Console.Write("Please Enter Percentage Grade: ");
        string userInput = Console.ReadLine();
        int pGrade = int.Parse(userInput);
        string lGrade = "";
        if (pGrade >= 90 && pGrade <=100)
        {lGrade = "A";}
        else if (pGrade >= 80)
        {lGrade = "B";}
        else if (pGrade >=70)
        {lGrade = "C";}
        else if (pGrade >=60)
        {lGrade = "D";}
        else {lGrade = "F";}
        string plusMinus = "";
        if (pGrade <= 93 && pGrade >= 60)
        {int plusMinusNum = (pGrade % 10);
        if (plusMinusNum >= 7)
        {plusMinus = "+";}
        if (plusMinusNum < 3)
        {plusMinus = "-";}
        }
        Console.WriteLine($"Your Letter Grade is an {lGrade}{plusMinus}");
        if (pGrade >= 70) {Console.WriteLine("You Passed! Congratulations");}
        else {Console.WriteLine("Unfortunately, you didn't pass. Best of luck next time!");}
    }
}