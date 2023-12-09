using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the goal program!");
        Recorder recorder = new Recorder();
        //Console.WriteLine("Debug: Created Recorder Object");
        string[] _options = { "q", "1", "2", "3", "4", "5" };
        //Menu!
        //Console.WriteLine("Debug: Created Options String");
        string userInput = "";
        bool changesSaved = true;
        //Console.WriteLine("Debug: Created userInput variable");
        while (userInput != "q")
        {
            recorder.DisplayPointsAndTitle(1);
            Console.WriteLine("\nMenu Options\n(1) Create a New Goal\n(2) List Goals\n(3) Save Goals\n(4) Load Goals\n(5) Record Event\n(q) Quit");
            userInput = Console.ReadLine().ToLower();

            //Make sure that they actually input a correct option
            while (!_options.Contains(userInput))
            {
                Console.Write("\nSorry, I didn't recognize that. Please re-enter your selection.\n-> ");
                userInput = Console.ReadLine().ToLower();
            }
            //Act on menu selection
            if (userInput == "1") {recorder.CreateGoal(); changesSaved = false;}//Create Goal
            else if (userInput == "2") { recorder.ListGoals(); }//List Goals
            else if (userInput == "3") { recorder.SaveToFile(); changesSaved = true; }//Save Goals
            else if (userInput == "4") { recorder.LoadFromFile(); }//Load Goals
            else if (userInput == "5") { recorder.RecordEvent(); changesSaved = false; }//Record Event
            else if (userInput == "q") { }
            else { Console.WriteLine("Error PD05-Goal-32"); }

        }
        if (!changesSaved) {
            Console.WriteLine("Wait! It looks like your changes aren't saved.\nEnter s to save or any other character to exit without saving.");
            string _save = Console.ReadLine().ToLower();
            if (_save == "s") {
                recorder.SaveToFile();
            }
        }
    }
}