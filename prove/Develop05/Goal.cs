//Goal Object Parent Class
abstract class Goal {
    private string _name;
    private string _description;
    private int _pointAmount;
    private bool _isCompletable;
    protected bool _isCompleted = false;
    protected int _completedRepetitions = 0;
    protected Goal(string name, string description, int points, bool completable){
        _name = name; _description = description; _pointAmount = points; _isCompletable = completable;
    }
    public abstract int RecordEvent();
    protected string StrIsComplete(){
        if (_isCompleted){return "X";}
        else {return " ";}
    }
    //"Getters"
    public bool IsComplete(){
        return _isCompleted;
    }
    public int GetPointAmount(){return _pointAmount;}
    public string GetName(){return _name;}
    public string GetDescription(){return _description;}
    public virtual string GetListString(){
        return $"[{StrIsComplete()}] {_name} ({_description})";
    }
    public virtual int GetTotalPoints(){ return _pointAmount * _completedRepetitions;}
    public abstract int GetTypeNumber();
    public virtual int GetCompletedRepetitions() { return _completedRepetitions;}
    //No longer getters
    public abstract bool CreateGoal();

}