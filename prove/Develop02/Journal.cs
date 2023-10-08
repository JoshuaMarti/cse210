public class Journal {
    public string JournalName;
    public List<Entry> Entries;
    public void Display() {
        int _entryNumber = 1;
        int _entryCount = Entries.Count();
        string _next = "";
        foreach (var item in Entries)
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
    
}