public class Customer
{
    private string _name;
    private Address _address;
    public bool IsInUSA(){
        return _address.IsInUSA();
    }
    public Customer(string name, Address address){
        _name = name; _address = address;
    }
    public string GetShippingLine() {return $"{_name}\n{_address.GetFormattedAddress()}";}
}