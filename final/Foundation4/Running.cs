class Running : Activity
{
    private double _distance;
    public override double GetDistance()
    {
        return _distance;
    }
    // public override double GetSpeed()
    // {
    //     throw new NotImplementedException();
    // }
    // public override double GetPace()
    // {
    //     throw new NotImplementedException();
    // }
    public Running(string date, double duration, double distance): base(date, duration){
        _distance = distance;
    }
}