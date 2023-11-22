class EternalGoal : Goal {
    public EternalGoal(string name, string description, int points, int _completedRepetitions = 0) :base(name, description, points, false){}
    public override int RecordEvent(){
        _completedRepetitions = _completedRepetitions + 1;
        return GetPointAmount();
    }
    public override bool CreateGoal()
    {
        return true;
    }
    public override int GetTypeNumber()
    {
        return 3;
    }
}