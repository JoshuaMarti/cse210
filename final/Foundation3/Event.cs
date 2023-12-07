abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    //private string _type; //Unnecessary, ended up just using GetType.
    private Address _address;
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title; _description = description; _date = date; _time = time; _address = address;
    }
    public virtual string GetShortDescription(){
        return $"Type: {this.GetType()}; Title: {_title}; Date: {_date};";
    }
    public virtual string GetStandardDetails(){
        return $"{_title}\n{_description}\nTo be held at {_time} on {_date} at\n{_address.GetFormattedAddress()}";
    }
    public abstract string GetFullDetails();
}