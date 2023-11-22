class SimpleGoal : Goal {
    public SimpleGoal(string name, string description, int points, int _completedRepetitions = 0) :base(name, description, points, true){}
    public override int RecordEvent(){
        _completedRepetitions = _completedRepetitions + 1;
        _isCompleted = true;
        return GetPointAmount();
    }
    public override bool CreateGoal()
    {
        return true;
    }
    public override int GetTypeNumber()
    {
        return 1;
    }
}