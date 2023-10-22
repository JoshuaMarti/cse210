using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please wait while I load in the library.");
        bool exit = false;
        //Create a library and load in scriptures from remote file.
        Library scriptureLibrary = new Library();
        scriptureLibrary.LoadScriptures();
        //LoadScriptureFiles.LoadScriptures(); Functionality moved to Library class.
        Console.WriteLine("Library loaded successfully!");
        Console.WriteLine("With that out of the way, welcome!\nI'm here to help you memorize a scripture of your choosing.\nCurrently, I support the entirety of the \"Standard Works\" of the Church of Jesus Christ.");
        while (!exit)
        {
            //First off, let's figure out what scripture the user is looking for.
            string[] scriptureArray = GetUserRequest(scriptureLibrary);
            Console.WriteLine($"So, how this works is whenever you press Enter, I'll blank out a few more words from the scripture. When you're ready to begin memorizing {scriptureArray[0]}, press Enter.");
            GradualRemoval(scriptureArray);
        }

    }
    static string[] GetScriptureText(string book, string chapter, int start, int end, Library scriptureLibrary)
    {
        int _countUpTo = end - start + 1;
        int _counter = start;
        string _reference = "";
        string _combinedScriptures = "";
        string _retrieve = "";
        string _got = "";
        if (start == end) { _reference = $"{book} {chapter}:{start}"; }
        else { _reference = $"{book} {chapter}:{start}-{end}"; }
        while (_counter < _countUpTo)
        {
            _retrieve = $"{book} {chapter}:{_counter}";
            //Console.WriteLine($"Debug: Retrieving {_retrieve}");
            _got = scriptureLibrary.GetScripture(_retrieve).scriptureText;
            //Console.WriteLine($"Debug: Text {_got}");
            _combinedScriptures = $"{_combinedScriptures} {_got}";
            //Console.WriteLine($"Debug: Combined to {_combinedScriptures}");
            _counter = _counter + 1;
        }
        string[] _returnArray = { _reference, _combinedScriptures };
        return _returnArray;
    }
    static string[] GetUserRequest(Library scriptureLibrary)
    {
        Console.WriteLine("Please type out the reference of the scripture you'd like help memorizing. I'm a little finnicky, so I'll need your help to put it in a format I understand. I'll ask you a few questions to make sure I know what scripture you're wanting help memorizing.");
        Console.WriteLine("First, what's the book? I'll need you to capitalize the first letter for me.\nAn example would be 'Genesis' or '1 Nephi' or 'Doctrine and Covenants'");
        string _book = Console.ReadLine();
        Console.WriteLine("\nGreat! Now, what chapter are we looking in? Just give me a number, please.");
        string _chapter = Console.ReadLine();
        Console.WriteLine("Beautiful, now, which verse are we starting with?");
        int _start = int.Parse(Console.ReadLine());
        Console.WriteLine("And finally, what's the last verse we're going to?\nIf it's the same as the first verse, please just enter that again.");
        int _end = int.Parse(Console.ReadLine());
        Console.WriteLine("Okay, let me check my library real quick.");
        string[] scriptureArray = GetScriptureText(_book, _chapter, _start, _end, scriptureLibrary);
        return scriptureArray;
    }
    static void GradualRemoval(string[] scriptureArray)
    {
        Random random = new Random();
        //Console.WriteLine(scriptureArray[1]);
        //Console.WriteLine("Debug: Made it to GradualRemoval");
        string _grReference = scriptureArray[0];
        string _grScripture = scriptureArray[1];
        string[] _words = _grScripture.Split(' ');
        List<int> _hiddenIndexes = new List<int>();
        //Get Word Count
        int _wordCount = _words.Length;
        double _mWC = _wordCount;
        double _hideTo = 5;
        double _hideStage = -1;
        int _randIndex = 0;
        while (_hideStage < _hideTo)
        {
            _hideStage = _hideStage + 1;
            string _sOut = "";
            int _hiddenQty = _hiddenIndexes.Count();
            int _needHidden = (int)Math.Round(_mWC * ((double)_hideStage / (double)_hideTo));
            //If more words need to be hidden, add them to the list of hidden words
            while (_hiddenQty < _needHidden)
            {
                _randIndex = random.Next(0, _wordCount);
                if (!_hiddenIndexes.Contains(_randIndex))
                {
                    _hiddenIndexes.Add(_randIndex);
                }
                _hiddenQty = _hiddenIndexes.Count();
            }
            //Generate Output
            for (var index = 0; index < _wordCount; index++)
            {
                if (_hiddenIndexes.Contains(index))
                {
                    int blanks = _words[index].Count();
                    //Insert underscores
                    for (var spot = 0; spot < blanks; spot++) { _sOut = _sOut + "_"; }
                    _sOut = _sOut + " ";
                }
                else { _sOut = _sOut + _words[index] + " "; }
            }


            //Clear Console and Display Output.
            Console.Clear();
            Console.WriteLine(_grReference);
            Console.WriteLine(_sOut);
            Console.ReadLine();
        }
    }
}