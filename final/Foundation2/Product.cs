class Product
{
    private string _name = "";
    private string _productId = "";
    private int _quantity = 0;
    private double _price = 0;
    public Product()
    {
    }
    public Product(string name, string productid, int quantity, double price)
    {
        _name = name;
        _productId = productid;
        _quantity = quantity;
        _price = CalculatePrice(price);
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public void SetProductId(string productId)
    {
        _productId = productId;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public double GetPrice()
    {
        return _price;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
    private double CalculatePrice(double price)
    {
        double totalPrice = price * _quantity;
        return totalPrice;
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"{_quantity} - {_name} - {_productId} - ${_price}");
    }

}