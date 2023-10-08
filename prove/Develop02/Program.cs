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
        List<string> Prompts = new List<string>();
        Prompts.Add("What are three things you were grateful for today? Why were you grateful for them?");
        Prompts.Add("How do you feel physically and emotionally right now?");
        Prompts.Add("What was an act of kindness you watched or did today? How'd it make you feel?");
        Prompts.Add("What was a challenge you faced today? How'd it go?");
        Prompts.Add("Was there a song or quote that was impactful for you today?");
        Prompts.Add("How are you feeling physically right now?");
        Prompts.Add("What were some of today's high and low points?");
        Prompts.Add("What's your plan for tomorrow? Is there anything you're looking forward to or worried about?");
        Prompts.Add("What did you do today for your own wellbeing?");
        
        string _options = "Welcome to the Journal Program Menu!\nPlease type the number for your desired option.\n1: Write New Journal Entry\n2: View Journal Entries\n3: Export Journal Entries\n4: Load Journal Entries\n5: Create Journal\n0: Exit\n\nSelection: ";
        string _input = "";
        Journal journal = null;
        int savedLastEntry = 1;

        //Menu();
        while (_input != "0") {
            Console.WriteLine(_options);
            _input = Console.ReadLine();
            if (_input == "1"){
                if (journal == null) {
                    Console.WriteLine("Hold on, you haven't created or loaded a journal yet!");
                    journal = CreateNewJournal();
                }
                WriteNewEntry(Prompts, journal);
                savedLastEntry = 0;}
            else if (_input == "2"){DisplayEntries(journal);}
            else if (_input == "3"){SaveEntries(journal);
            savedLastEntry = 1;}
            else if (_input == "4"){LoadEntries(journal);}
            else if (_input == "5"){CreateNewJournal();}
            else {}
        }
        //Last chance save check before exiting
        if (savedLastEntry == 0) {
            Console.WriteLine("Hold on, it looks like you didn't save your journal to a file!\nWould you like to before you quit? (y/n)");
            _input = Console.ReadLine();
            while ((_input != "y") && (_input != "n") ) {Console.WriteLine("I didn't understand that. Please enter 'y' or 'n'"); _input = Console.ReadLine();}
            if (_input == "y") { SaveEntries(journal); }

        }
        Console.WriteLine("Program Exited Gracefully. I hope you have a lovely evening!");
            }
    static Journal CreateNewJournal() {
        //Create new journal and name it
        Journal journal = new Journal();
        Console.WriteLine();
        Console.Write("Please enter a Journal Name: ");
        journal.JournalName = Console.ReadLine();
        return journal;
    }
    static void WriteNewEntry(List<string> _promptList, Journal journal) {
        List<String> Prompts = _promptList;
        Random _rndm = new Random();
        int _promptTemp = 0;
        //For creating a new entry, pick and display four prompts and get their responses, and save the entry to the journal.
        //First, we create the entry and set the date and prompts
        Entry entry = new Entry();
        entry.EntryDate = DateTime.Now.ToShortDateString();
        _promptTemp = _rndm.Next(0, (Prompts.Count - 1));
        entry.Prompt1 = Prompts[_promptTemp];
        Prompts.RemoveAt(_promptTemp);
        entry.Response1 = "";

        _promptTemp = _rndm.Next(0, (Prompts.Count - 1));
        entry.Prompt2 = Prompts[_promptTemp];
        Prompts.RemoveAt(_promptTemp);
        entry.Response2 = "";

        _promptTemp = _rndm.Next(0, (Prompts.Count - 1));
        entry.Prompt3 = Prompts[_promptTemp];
        Prompts.RemoveAt(_promptTemp);
        entry.Response3 = "";

        _promptTemp = _rndm.Next(0, (Prompts.Count - 1));
        entry.Prompt4 = Prompts[_promptTemp];
        Prompts.RemoveAt(_promptTemp);
        
        //With that taken care of, we now give the user the prompts and then record their replies. After each reply, we'll give them the option to edit their response or continue.
        Console.WriteLine("\n\n\nWelcome! Please respond to the provided prompts below.\nAfter replying, enter \"s\" to save or \"e\" to edit.\n\n");
        Console.Write("\n\n" + entry.Prompt1 + "\n");
        string _saveEdit = "e";
        while (_saveEdit == "e") {
        entry.Response1 = Console.ReadLine();
        Console.Write("Save or Edit? ");
        _saveEdit = Console.ReadLine(); }
        _saveEdit = "e";

        Console.Write("\n\n" + entry.Prompt2 + "\n");
        while (_saveEdit == "e") {
        entry.Response2 = Console.ReadLine();
        Console.Write("Save or Edit? ");
        _saveEdit = Console.ReadLine(); }
        _saveEdit = "e";

        Console.Write("\n\n" + entry.Prompt3 + "\n");
        while (_saveEdit == "e") {
        entry.Response3 = Console.ReadLine();
        Console.Write("Save or Edit? ");
        _saveEdit = Console.ReadLine(); }
        _saveEdit = "e";

        Console.Write("\n\n" + entry.Prompt4 + "\n");
        while (_saveEdit == "e") {
        entry.Response4 = Console.ReadLine();
        Console.Write("Save or Edit? ");
        _saveEdit = Console.ReadLine(); }

        //Finally, we'll save the entry into the journal.
        journal.Entries.Add(entry);
        Console.WriteLine("Your journal entry has been added to the journal =D");

    }
    static void DisplayEntries(Journal journal) {
        journal.Display();
    }
    static void LoadEntries(Journal journal) {
        string _confirm = "n";
        string filename = "";
        while (_confirm != "y") {
        Console.WriteLine("Please enter the filename for the journal you'd like to load in.");
        filename = Console.ReadLine();
        Console.WriteLine("You are trying to load " + filename + " . Is that correct? (y/n)");
        _confirm = Console.ReadLine();
        }
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("§");
            Entry entry = new Entry();
            entry.EntryDate = parts[0];
            entry.Prompt1 = parts[1];
            entry.Prompt2 = parts[2];
            entry.Prompt3 = parts[3];
            entry.Prompt4 = parts[4];
            entry.Response1 = parts[5];
            entry.Response2 = parts[6];
            entry.Response3 = parts[7];
            entry.Response4 = parts[8];
            journal.Entries.Add(entry);
        }
    }
    static void SaveEntries(Journal journal) {
        //Make sure it's actually gonna be saved where they want.
        string _confirm = "n";
        string filename = "";
        int _fileExists = 1;
        while ((_confirm != "y") && (_fileExists != 0) ) {
        Console.WriteLine("Please enter the filename you'd like to save your journal to.");
        filename = Console.ReadLine();
        Console.WriteLine("You are trying to save your journal to " + filename + " . Is that correct? (y/n)");
        _confirm = Console.ReadLine();
        if (File.Exists(filename)) {
            _fileExists = 1;
            Console.WriteLine("Unfortunately, " + filename + "already exists. Enter a different filename.");
        }
        else {_fileExists = 0;}
        }

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var item in journal.Entries)
            {
                outputFile.WriteLine(item.EntryDate + "§" + item.Prompt1 + "§" + item.Prompt2 + "§" + item.Prompt3 + "§" + item.Prompt4 + "§" + item.Response1 + "§" + item.Response2 + "§" + item.Response3 + "§" + item.Response4);
            }
        }
    }
}