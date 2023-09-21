using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> collection = new List<int>();
        string userInput = "";
        int input = 1;
        Console.WriteLine("Please enter a list of numbers, enter 0 when finished.");
        do {
            Console.WriteLine();
            Console.Write("Number: ");
            userInput = Console.ReadLine();
            input = int.Parse(userInput);
            collection.Add(input);

        } while (input != 0);
        //Things to calculate
        int sum = 0;
        int average = 0;
        int largest = collection[0];
        //int smallest = collection[0];
        int quantity = collection.Count();
        foreach (int number in collection) {
            sum = sum + number;
            if (number > largest){largest = number;}
            //if (number < smallest) {smallest = number;}
        }
        average = sum / quantity;
        Console.WriteLine($"You entered {quantity} numbers.");
        Console.WriteLine($"The sum was {sum}");
        Console.WriteLine($"The average was {average}");
        Console.WriteLine($"The largest number was {largest}");
        //Console.WriteLine($"The smallest number was {smallest}");
    }
}