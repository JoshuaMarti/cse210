class ChecklistGoal : Goal {
    private int _repetitions;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int _repetitions = 0, int _completedRepetitions = 0) :base(name, description, points, true){}
    public override int RecordEvent(){
        _completedRepetitions = _completedRepetitions + 1;
        if (_completedRepetitions >= _repetitions){_isCompleted = true; return (GetPointAmount() + _bonus);}
        else{
        return GetPointAmount();}
    }
    public override bool CreateGoal()
    {
        Console.Write("\nSince this is a checklist goal, how many times do you want the task to be completed before it is marked complete?\n->");
        _repetitions = int.Parse(Console.ReadLine());
        Console.Write("\n\nOkay, and when the goal is finally completed, how many bonus points do you want?\n->");
        _bonus = int.Parse(Console.ReadLine());
        return true;
    }
    public override string GetListString(){
        return $"[{StrIsComplete()}] {GetName()} ({GetDescription()}) -- Currently Completed {_completedRepetitions}/{_repetitions}";
    }
    public override int GetTotalPoints()
    {
        if (_isCompleted){ return base.GetTotalPoints() + _bonus;}
        else{
        return base.GetTotalPoints();
        }
    }
    public override int GetTypeNumber()
    {
        return 2;
    }
}