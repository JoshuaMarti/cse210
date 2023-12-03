public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private double _quantity;
    public Product(string name, string id, double price, double quantity){
        _name = name; _id = id; _price = price; _quantity = quantity;
    } //Constructor
    //Get the total price
    public double GetTotalPrice(){ return _price * _quantity;}
    public string GetPackingLine() { return $"{_name}, {_id}";}
}