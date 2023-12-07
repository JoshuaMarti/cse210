class Cycling : Activity
{
    private double _speed;
    // public override double GetDistance()
    // {
    //     throw new NotImplementedException();
    // }
    public override double GetSpeed()
    {
        return _speed;
    }
    // public override double GetPace()
    // {
    //     throw new NotImplementedException();
    // }
    public Cycling(string date, double duration, double speed): base(date, duration){
        _speed = speed;
    }
}