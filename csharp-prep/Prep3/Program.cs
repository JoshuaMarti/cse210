using System;

class Program
{
    static void Main(string[] args)
    {
        //Generate the random number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        //Guessing Loop
        int guess = 0;
        int guessCounter = 0;
        do {
            Console.WriteLine();
            Console.Write("Guess a number: ");
            string guessTemp = Console.ReadLine();
            guess = int.Parse(guessTemp);
            guessCounter += 1;
            if (guess > number) {Console.WriteLine("Lower");}
            else if (guess < number) {Console.WriteLine("Higher");}
            else {Console.WriteLine($"Congratulations! The number was indeed {number}. It took you {guessCounter} guesses.");}
        } while (guess != number);
    }
}