using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.IO;

//Attributions:
//Some guidance for writing this was obtained from various Generative Text Models. No code was copied from the models' output. For more info, email ims (at) josh47.com and reference "CSE210 Prove Develop02 2310" in the body.
//Assistance for the framework of this program was given by Tim Thayne and https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
class Program
{
    static void Main(string[] args)
    {
        //Establish the collection of prompts and other variables to be used later on
        private List<string> _prompts = new List<string>();
        _prompts.Add("What are three things you were grateful for today? Why were you grateful for them?");
        _prompts.Add("How do you feel physically and emotionally right now?");
        _prompts.Add("What was an act of kindness you watched or did today? How'd it make you feel?");
        _prompts.Add("What was a challenge you faced today? How'd it go?");
        _prompts.Add("Was there a song or quote that was impactful for you today?");
        _prompts.Add("How are you feeling physically right now?");
        _prompts.Add("What were some of today's high and low points?");
        _prompts.Add("What's your plan for tomorrow? Is there anything you're looking forward to or worried about?");
        _prompts.Add("What did you do today for your own wellbeing?");
        
        string _options = "Welcome to the Journal Program Menu!\nPlease type the number for your desired option.\n1: Write New Journal Entry\n2: View Journal Entries\n3: Export Journal Entries\n4: Load Journal Entries\n5: Create Journal\n0: Exit\n\nSelection: ";
        string _input = "";
        Journal journal = new Journal;
        int savedLastEntry = 1;

        //Menu();
        while (_input != "0") {
            Console.WriteLine(_options);
            _input = Console.ReadLine();
            if (_input == "1"){
                if (journal.GetName() == null) {
                    Console.WriteLine("First, let's name the journal :-)");
                    journal.InteractiveSetName();
                }
                WriteNewEntry(_prompts); savedLastEntry = 0;}
            else if (_input == "2"){journal.Display();}
            else if (_input == "3"){journal.SaveEntries(); savedLastEntry = 1;}
            else if (_input == "4"){journal.LoadEntries();}
            else if (_input == "5"){CreateNewJournal();}
            else {}
        }
        //Last chance save check before exiting
        if (savedLastEntry == 0) {
            Console.WriteLine("Hold on, it looks like you didn't save your journal to a file!\nWould you like to before you quit? (y/n)");
            _input = Console.ReadLine();
            while ((_input != "y") && (_input != "n") ) {Console.WriteLine("I didn't understand that. Please enter 'y' or 'n'"); _input = Console.ReadLine();}
            if (_input == "y") { journal.SaveEntries; }

        }
        Console.WriteLine("Program Exited Gracefully. I hope you have a lovely evening!");
            }

    //static void WriteNewEntry(List<string> _promptList, Journal journal) { //Functionality moved to Journal.cs on 2023 11 22, Line 39 adjusted accordingly.
    // //static void DisplayEntries(Journal journal) { <-Removed as redundant, adjusted Line 41 accordingly
    //     journal.Display();
    // }
    //2023 11 22 -> The static LoadEntries and SaveEntries methods were moved from here and implemented in Journal.cs
}