using System.Collections.Concurrent;

public class Listing : Activity {
    private string[] _prompts;
    Random _rndm = new Random();
    private List<int> _usedPrompts = new List<int>();
    public Listing(string name, string description, string[] prompts) :base(name, description){ _prompts = prompts;}
    public void RunActivity() {
        StartActivity();
        Console.WriteLine("Excellent! Now, I'll show you a prompt and you can type in as many answers as you can think of in the duration you selected =D\nI'll give you a few seconds to think before you have to start typing though, no worries.");
        //Pick a random prompt, mark it as used, and display it.
        bool _pickedPrompt = false;
        int _index = 0;
        while (!_pickedPrompt){
            //If all prompts have been selected, reset.
            if (_usedPrompts.Count == _prompts.Length){_usedPrompts.Clear();}

            //Pick a random number, check if it's been picked, if it hasn't then go ahead and use it.
            _index = _rndm.Next(0, _prompts.Length);
            if (!_usedPrompts.Contains(_index)){
                _pickedPrompt = true;
                _usedPrompts.Add(_index);
            }
        }
        Console.WriteLine(_prompts[_index]);
        ShowCountdown(5);
        Console.WriteLine("\nEnter your answers when you're ready.");
        //Set up timer
        DateTime _now = DateTime.Now;
        DateTime _endTime = _now.AddSeconds(_duration);
        //Collect answers
        List<string> _answers = new List<string>();
        while (_now < _endTime){
            _now = DateTime.Now;
            _answers.Add(Console.ReadLine());
        }
        //Display the ending stuff
        Console.WriteLine($"You entered {_answers.Count} things :-)");
        Console.WriteLine(_endMessage);
        Console.ReadLine();
    }
}