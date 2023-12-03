using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");
        List<Order> _orders = new List<Order>();
        //First Order
        Address _address = new Address("125 Sesame Street", "New York City", "New York", "USA");
        Customer _customer = new Customer("Oscar", _address);
        List<Product> _products = new List<Product>();
        Product _p1 = new Product("CRT Television","1969", 7.21, 2);
        _products.Add(_p1);
        Product _p2 = new Product("Anchovy Milkshake", "601", 0.79, 3);
        _products.Add(_p2);
        Order _o1 = new Order(_products, _customer);
        _orders.Add(_o1);
        //Second Order
        List<Product> _products2 = new List<Product>();
        _address = new Address("Phoenix Foundation\n1333 West Georgia Street", "Vancouver", "British Columbia", "Canada");
        _customer = new Customer("Angus", _address);
        _p1 = new Product("Duct Tape","1985", 9.29, 2);
        _products2.Add(_p1);
        _p2 = new Product("Wrangler", "1987", 8999.95, 1);
        _products2.Add(_p2);
        Order _o2 = new Order(_products2, _customer);
        _orders.Add(_o2);

        foreach(Order order in _orders){
            Console.WriteLine($"\nPacking Label\n{order.GetPackingLabel()}");
            
            Console.WriteLine($"\nShipping Label\n{order.GetShippingLabel()}");
            
            Console.WriteLine($"\nTotal Cost\n{order.GetTotalCost()}");
            
        }
    }
}