class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();
    private double _sumOfOrder = 0;
    private double _shippingFee = 0;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
        _shippingFee = CalculateShippingFee();
        _sumOfOrder = CalculateSumOfOrder();
    }
    public List<Product> GetProducts()
    {
        return _products;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(string name, string streetAddress, string city, string stateOrProvince, string country)
    {
        _customer.SetName(name);
        _customer.SetAddress(streetAddress, city, stateOrProvince, country);
    }
    public double GetSumOfOrder()
    {
        return _sumOfOrder;
    }
    public void SetSumOfOrder(double sumOfOrder)
    {
        _sumOfOrder = sumOfOrder;
    }
    public double GetShippingFee()
    {
        return _shippingFee;
    }
    public void SetShippingFee(double shippingFee)
    {
        _shippingFee = shippingFee;
    }
    public double CalculateSumOfOrder()
    {
        double sum = 0;

        foreach(var product in _products)
        {
            double price = product.GetPrice();
            sum += price;
        }
        sum += _shippingFee;
        return sum;
    }
    public double CalculateShippingFee()
    {
        double shippingFee = 0;

        if(_customer.GetUSAOrNot() == "yes")
        {
            shippingFee = 5;
        }
        else if (_customer.GetUSAOrNot() == "no")
        {
            shippingFee = 35;
        }
        return shippingFee;
    }
    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Order:");

        foreach(var product in _products)
        {
            string name = product.GetName();
            string productId = product.GetProductId();

            Console.WriteLine($"{name} - {productId}");
        }
    }
    public void DisplayShippingLabel()
    {
        string name = _customer.GetName();
        string address = _customer.AddressString();

        Console.WriteLine($"Name: {name} Address: {address}");
    }
    public void DisplaySumOfOrder()
    {
        Console.WriteLine($"Total: ${_sumOfOrder}");
    }
}