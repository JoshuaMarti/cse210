abstract class Activity
{
    private string _date;
    private double _duration; public double GetDuration() {return _duration;}
    public virtual double GetDistance() {return GetSpeed() * (GetDuration() / 60);} //kilometers
    public virtual double GetSpeed() {return GetDistance() / (GetDuration() / 60);} //km/h
    public virtual double GetPace() {return GetDuration() / GetDistance();} //minutes per km
    public virtual string GetSummary(){
        //Example: 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
        return _date + " " + GetType() + " (" + _duration + " min): Distance " + Math.Round(GetDistance(), 2) + " km, Speed: " + Math.Round(GetSpeed(), 2) + " kph, Pace: " + Math.Round(GetPace(), 2) + " minutes per kilometer";
    }
    public Activity(string date, double duration)
    {
        _date = date; _duration = duration;
    }
}