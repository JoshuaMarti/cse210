public class Journal {
    private string _name = null;
    public string GetName() { return _name;}
    public void SetName(string name) {_name = name;}
    public void InteractiveSetName() {
        Console.WriteLine();
        Console.Write("Please enter a Journal Name: ");
        _name = Console.ReadLine();
    }
    private List<Entry> _entries = new List<Entry>();
    public void Display() {
        int _entryNumber = 1;
        int _entryCount = _entries.Count();
        string _next = "";
        foreach (var item in _entries)
        {
            Console.WriteLine("\n\nEntry #" + _entryNumber + "of " + _entryCount +": " + item.EntryDate);
            Console.WriteLine("Prompt: " + item.Prompt1 + "\nReply: " + item.Response1 + "\n");
            Console.WriteLine("Prompt: " + item.Prompt2 + "\nReply: " + item.Response2 + "\n");
            Console.WriteLine("Prompt: " + item.Prompt3 + "\nReply: " + item.Response3 + "\n");
            Console.WriteLine("Prompt: " + item.Prompt4 + "\nReply: " + item.Response4 + "\n");
            Console.Write("Press Enter to continue.");
            _next = Console.ReadLine();
        }
    }
    public void LoadEntries() {
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
            _entries.Add(entry);
        }
    }
    public void SaveEntries() {
        //Make sure it's actually gonna be saved where they want.
        string _confirm = "n";
        string _filename = "";
        int _fileExists = 1;
        while ((_confirm != "y") && (_fileExists != 0) ) {
        Console.WriteLine("Please enter the filename you'd like to save your journal to.");
        _filename = Console.ReadLine();
        Console.WriteLine("You are trying to save your journal to " + _filename + " . Is that correct? (y/n)");
        _confirm = Console.ReadLine();
        if (File.Exists(_filename)) {
            _fileExists = 1;
            Console.WriteLine("Unfortunately, " + _filename + "already exists. Enter a different filename.");
        }
        else {_fileExists = 0;}
        }

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (var item in _entries)
            {
                outputFile.WriteLine(item.EntryDate + "§" + item.Prompt1 + "§" + item.Prompt2 + "§" + item.Prompt3 + "§" + item.Prompt4 + "§" + item.Response1 + "§" + item.Response2 + "§" + item.Response3 + "§" + item.Response4);
            }
        }
    }
    public void WriteNewEntry(List<string> _promptList) {
        List<String> _prompts = _promptList;
        Random _rndm = new Random();
        int _promptTemp = 0;
        //For creating a new entry, pick and display four prompts and get their responses, and save the entry to the journal.
        //First, we create the entry and set the date and prompts
        Entry entry = new Entry();
        entry.EntryDate = DateTime.Now.ToShortDateString();
        _promptTemp = _rndm.Next(0, (_prompts.Count - 1));
        entry.Prompt1 = _prompts[_promptTemp];
        _prompts.RemoveAt(_promptTemp);
        entry.Response1 = "";

        _promptTemp = _rndm.Next(0, (_prompts.Count - 1));
        entry.Prompt2 = _prompts[_promptTemp];
        _prompts.RemoveAt(_promptTemp);
        entry.Response2 = "";

        _promptTemp = _rndm.Next(0, (_prompts.Count - 1));
        entry.Prompt3 = _prompts[_promptTemp];
        _prompts.RemoveAt(_promptTemp);
        entry.Response3 = "";

        _promptTemp = _rndm.Next(0, (_prompts.Count - 1));
        entry.Prompt4 = _prompts[_promptTemp];
        _prompts.RemoveAt(_promptTemp);
        
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
        _entries.Add(entry);
        Console.WriteLine("Your journal entry has been added to the journal =D");

    }
    public void NewJournal(){
        if (_entries.Count() == 0) {
            if (_name == null) {
                InteractiveSetName();
            }
            else {
                Console.WriteLine($"This empty journal is already named {_name}. Would you like to rename it?");
                Console.Write("Y/N ->");
                var _confirm = Console.ReadLine().ToLower();
                if (_confirm == "y") {InteractiveSetName();}
            }
        }
        else{//If there are existing entries.
            if (_name == null) {
                    Console.WriteLine($"There are {_entries.Count()} entries stored in an unnamed journal.");
                    InteractiveSetName();}
            else {
                Console.WriteLine($"There are already {_entries.Count()} entries in your journal named {_name}\nWould you like to remove the entries and rename the journal?");
                Console.Write("Y/N ->");
                var _confirm = Console.ReadLine().ToLower();
                if (_confirm == "y") {
                    _entries.Clear();
                    InteractiveSetName();
                }
            }
        }
    }
}