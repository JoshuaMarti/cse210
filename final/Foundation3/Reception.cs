class Reception : Event
{
    private string _contact;
    public Reception(string title, string description, string date, string time, Address address, string contact) :base(title, description, date, time, address)
    {
        _contact = contact;
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nFor more info, please contact {_contact}";
    }
}