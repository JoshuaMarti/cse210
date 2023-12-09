class SimpleGoal : Goal {
    public SimpleGoal(string name, string description, int points, int _completedRepetitions = 0, bool isCompleted = false) :base(name, description, points, true, _completedRepetitions, isCompleted){}
    public override int RecordEvent(){
        if (!_isCompleted) {
        _completedRepetitions = _completedRepetitions + 1;
        _isCompleted = true;
        return GetPointAmount();
        }
        else {
            Console.WriteLine("This goal has already been completed.");
            return 0;}
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