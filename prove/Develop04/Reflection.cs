public class Reflection : Activity {
    private string[] _prompts;
    private string[] _questions;
    private List<int> _usedPrompts = new List<int>();
    private List<int> _usedQuestions = new List<int>();
    public Reflection(string name, string description, string[] prompts, string[]questions) :base(name, description){_prompts = prompts; _questions = questions;}
    public void RunActivity(){
        StartActivity();
        Console.WriteLine(GetPrompt() + "\n");
        //Set up timer
        DateTime _now = DateTime.Now;
        DateTime _endTime = _now.AddSeconds(_duration);

        //Display a question every 5 seconds until the timer runs out.
        while (_now < _endTime){
            Console.WriteLine(GetQuestion());
            ShowCountup(7);
            ClearCountdown();
            _now = DateTime.Now;
        }
        Console.WriteLine(_endMessage);
        Console.ReadLine();
    }
    public string GetPrompt() {
        Random _rndm = new Random();
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
        return _prompts[_index];
    }
    public string GetQuestion() {
        Random _rndm = new Random();
        bool _pickedQuestion = false;
        int _index = 0;
        while (!_pickedQuestion){
            //If all prompts have been selected, reset.
            if (_usedQuestions.Count == _questions.Length){_usedQuestions.Clear();}

            //Pick a random number, check if it's been picked, if it hasn't then go ahead and use it.
            _index = _rndm.Next(0, _questions.Length);
            if (!_usedQuestions.Contains(_index)){
                _pickedQuestion = true;
                _usedQuestions.Add(_index);
            }
        }
        return _questions[_index];
    }
}