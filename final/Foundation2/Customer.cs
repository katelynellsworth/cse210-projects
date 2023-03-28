class Customer
{
    private string _name = "";
    private Address _address = new Address();
    private string _yesOrNoUSA = "";
    public Customer()
    {
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        _yesOrNoUSA = address.DetermineIfUSA();
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public void SetAddress(string streetAddress, string city, string stateOrProvince, string country)
    {
        _address.SetStreetAddress(streetAddress);
        _address.SetCity(city);
        _address.SetStateOrProvince(stateOrProvince);
        _address.SetCountry(country);
    }
    public string GetUSAOrNot()
    {
        return _yesOrNoUSA;
    }
    public void SetUSAOrNot(string yesOrNoUSA)
    {
        _yesOrNoUSA = yesOrNoUSA;
    }
    public void DisplayCustomer()
    {
        Console.WriteLine(_name);
        _address.DisplayAddress();
    }
    public string AddressString()
    {
        string address = _address.CreateAddress();
        return address;
    }

}