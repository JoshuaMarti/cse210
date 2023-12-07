class Lecture : Event
{
    private int _capacity;
    private string _speaker;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) :base(title, description, date, time, address)
    {
      _capacity = capacity; _speaker = speaker;  
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nThe lecture will be given by {_speaker} and there are {_capacity} seats in the space";
    }
}