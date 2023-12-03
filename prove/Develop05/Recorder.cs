//This class does the bulk of the work, managing the goals, points, titles, and files.
using System.Diagnostics.Metrics;

public class Recorder{
    private List<Goal> _goals = new List<Goal>();
    private int _points; //Total Point Counter
    private string _title; //Stores the current title
    public Recorder(){}
    public void CreateGoal(){//Create a goal and add it to the list
        bool _confirm = false;
        //Goal Attribute Declarations
        string _tempGoalType = "";
        string _tempName = "";
        string _tempDescription = "";
        int _tempPoints = 0;
        while (!_confirm){
        //Get the goal type
        Console.WriteLine("\n\n\nWhat sort of goal would you like to create?\n[1] Simple\n[2] Checklist\n[3] Eternal");
        // //tempGoalType was declared here but we need it outside the loop so I moved it.
        string[] _goalOptions = {"1", "2", "3"};
        string[] _goalNames = {"", "Simple", "Checklist", "Eternal"};
        while (!_goalOptions.Contains(_tempGoalType)) {
            Console.Write("\nPlease enter 1, 2, or 3\n->");
            _tempGoalType = Console.ReadLine();
        }
        int _tempGoalInt = int.Parse(_tempGoalType);
        //Get the goal name
        Console.Write("\n\nPlease enter a name for the goal\n->");
        _tempName = Console.ReadLine();
        //Get the goal description
        Console.Write("\n\nNow, please write a description for the goal\n->");
        _tempDescription = Console.ReadLine();
        //And finally, how many points is it worth?
        Console.Write("\n\nHow many points do you want this goal to be worth when completed?\n->");
        _tempPoints = int.Parse(Console.ReadLine());
        //Confirm their entry.
        Console.Write($"\n\nOkay, just making sure I've got this right. You want to make a {_goalNames[_tempGoalInt]} goal named {_tempName}, described as {_tempDescription} worth {_tempPoints} points. Is that correct?");

        //Check that they entered Y or N and get them to if they didn't
        string _confirmation = "";
        while (_confirmation != "Y" && _confirmation != "N") {
            Console.Write("\nY/N ->");
            _confirmation = Console.ReadLine().ToUpper();}
        if (_confirmation == "Y") {_confirm = true;}
        }//End the while loop for getting goal info confirmed

        //Now that we have all the info general to each variety of goals, we'll create the goal and call its creation logic to get any additional information that specific goal needs.
        
        if (_tempGoalType == "1"){
            Goal newGoal = new SimpleGoal(_tempName, _tempDescription, _tempPoints);
            newGoal.CreateGoal();
            _goals.Add(newGoal);
        }
        else if (_tempGoalType == "2") {
            Goal newGoal = new ChecklistGoal(_tempName, _tempDescription, _tempPoints);
            newGoal.CreateGoal();
            _goals.Add(newGoal);
        }
        else if (_tempGoalType == "3") {
            Goal newGoal = new EternalGoal(_tempName, _tempDescription, _tempPoints);
            newGoal.CreateGoal();
            _goals.Add(newGoal);
        }
        else {Console.WriteLine("Error CS-D05-Recorder 58 - Please email ims@josh47.com for assistance.");}
        //With that all done, we're good to go!
        Console.WriteLine("Perfect! Your goal has been completed.");
    }
    public void ListGoals(){//Nicely format the list of goals and print them out
    Console.WriteLine("\n\n\nThe goals are:");
    ListOutGoals();
    
    }
    public void RecordEvent(){//Record the completion or performance of a goal
        Console.WriteLine("\n\n\nPlease select an incomplete goal from the following:");
        ListOutGoals();
        Console.Write("Enter Numerical Selection ->");
        int _selection = int.Parse(Console.ReadLine()) - 1; //Adjust to the index in the list
        int _newPoints = _goals[_selection].RecordEvent(); //Have the goal record the event and then return the points.
        Console.WriteLine($"\nCongratulations! You got {_newPoints} points for completing your {_goals[_selection].GetName()} goal!");

        _points = _points + _newPoints; //Record the additional points.

        //Check if they got a new title
        string _titleCheck = CheckTitle();
        if (_title != _titleCheck) {
            _title = _titleCheck;
            Console.WriteLine("Huzzah! You've achieved the rank of {_title}");
        }

    }
    public int CountPoints(){//Count up all the points if needed
        int _countPoints = 0;
        foreach (Goal goal in _goals) {
            _countPoints = _countPoints + goal.GetTotalPoints();
        }
        return _countPoints;
    }
    public string CheckTitle(){
        return Titles.GetTitle(_points);
    }
    public void DisplayPointsAndTitle(int spacing = 0){
        while (spacing > 0){
            Console.Write("\n"); spacing = spacing - 1;
        }
        _title = CheckTitle();
        Console.WriteLine("You have " + _points + "points and have the title of" + _title + ".");
    }
    public void SaveToFile(){
        //Figure out where they want to save the file
        Console.Write($"\n\n\nWhere would you like to save the file?\nExample 1: C:\\\\Users\\\\user\\\\downloads\\\\mygoal.grf\nExample 2: mygoal.grf\n-> ");
        string _filePath = Console.ReadLine();
        //Check if the file exists and give them the option to overwrite if it does
        bool _writePermission = true;
        if (File.Exists(_filePath)) {
            _writePermission = false;
            Console.Write($"\n\n{_filePath} already exists.\nDo you wish to overwite?\nY/N ->");
            string _overwriteSelection = Console.ReadLine().ToLower();
            if (_overwriteSelection == "y") {_writePermission = true;}
        }
        if (_writePermission == false) {Console.WriteLine("Unable to write to file. Returning to Main Menu.");}
        else {
        // //Data format is type#|name|description|points|completedRepetitions|isComplete|check|requiredRepetitions
        int _checkSum = 0;
        Random rndm = new Random();
        int _length = _goals.Count();
        List<string> _export = new List<string>();
        foreach (Goal goal in _goals)
        {
            int chk = rndm.Next(0,64);

            string _str = goal.GetTypeNumber() + "|" + goal.GetName() + "|" + goal.GetDescription() + "|" + goal.GetTotalPoints() + "|" + goal.GetCompletedRepetitions() + "|" + goal.IsComplete() + "|" + chk;
            _checkSum = _checkSum + chk;
            _export.Add(_str);
        }
        // //First line format is GoalExport|date|number of goals|check
        DateTime date = DateTime.UtcNow;
        string _current = $"{date}";
        string _firstLine = "GoalExport|" + _current + "|" + _length + "|" + _checkSum;
        using (StreamWriter outputFile = new StreamWriter(_filePath))
        {
            outputFile.WriteLine(_firstLine);
            foreach (var item in _export)
            {
                outputFile.WriteLine(item);
            }
        }

    }}
    public void LoadFromFile(){
        string _confirm = "n";
        string filename = "";
        while (_confirm != "y") {
        Console.WriteLine("Please enter the filename for the journal you'd like to load in.");
        filename = Console.ReadLine();
        Console.WriteLine("You are trying to load " + filename + " . Is that correct? (y/n)");
        _confirm = Console.ReadLine();
        }
        string[] lines = System.IO.File.ReadAllLines(filename);
        bool _notFirst = false;
        int _checkTotal = 0;
        int _checkSum = 0;

        foreach (string line in lines)
        {
            //First line format is GoalExport|date|number of goals|check
            //Data format is type#|name|description|points|completedRepetitions|isComplete|check|requiredRepetitions
            string[] parts = line.Split("|"); //Handle first line differently than others.
            if(!_notFirst) {
                _notFirst = true;
                _checkTotal = int.Parse(parts[3]);

            }
            else {
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
            _entries.Add(entry);}
        }
    }
    private void ListOutGoals(){//Lists all the goals but doesn't do any other formatting
        var _counter = 0;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(_counter + ". " + goal.GetListString()); 
            _counter++;
        }
    }
}