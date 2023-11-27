public class Address {
    private string _streetAddress;
    private string _city;
    private string _region;
    private string _nation;
    public Address(string StreetAddress, string City, string Region, string Nation){
        _streetAddress = StreetAddress; _city = City; _region = Region; _nation = Nation;
    }
    public string GetFormattedAddress(){
        return $"{_streetAddress}\n{_city}, {_region}\n{_nation}"
    }
    public bool IsInUSA{
        string _ = _nation.ToLower()
        if (_ == "usa" || _ == "united states" || _ == "usoa" || _ ==  "united states of america" || _ == "us"){
            return true;
        }
        else {return false;}
    }
}