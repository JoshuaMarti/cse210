class Swimming : Activity
{
    private double _laps;
    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public Swimming(string date, double duration, double laps): base(date, duration){
        _laps = laps;
    }
}