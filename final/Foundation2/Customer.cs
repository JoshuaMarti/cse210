public class Customer
{
    private string _name;
    private Address _address;
    public bool IsInUSA(){
        if (_address == null) {return null;}
        else {return _address.IsInUSA();}
    }
}