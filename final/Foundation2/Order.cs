public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(List<Product> products, Customer customer){
        _products = products; _customer = customer;
    } //Constructor
    //Methods
    public double GetTotalCost(){
        double _cost = 0; //Add up costs of products
        foreach (Product product in _products)
        {
            _cost = _cost + product.GetTotalPrice();
        }
        //Determine shipping cost
        if (_customer.IsInUSA()) {_cost = _cost + 5;}
        else {_cost = _cost + 35;}
        return _cost;
    }
    public string GetPackingLabel() { //The name and product ID for each product in the order
        string _ = "";
        foreach (Product product in _products)
        {
            _ = _ + product.GetPackingLine() + "\n";
        }
        return _;
    }
    public string GetShippingLabel() {//Name and address
        return _customer.GetShippingLine();
    }
}