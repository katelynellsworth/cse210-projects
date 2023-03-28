class Address 
{
    private string _streetAddress = "";
    private string _city = "";
    private string _stateOrProvince = "";
    private string _country = "";
    private string _address = "";
    public Address()
    {
    }
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }
    public void SetStateOrProvince(string stateOrProvince)
    {
        _stateOrProvince = stateOrProvince;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public string GetAddress()
    {
        return _address;
    }
    public void SetAddress(string address)
    {
        _address = address;
    }
    public string DetermineIfUSA()
    {
        if(_country == "USA")
        {
            return "yes";
        }
        else
        {
            return "no";
        }
    }
    public string CreateAddressString()
    {
        return $"{_streetAddress}, {_city}, {_stateOrProvince}, {_country}";
    }
    public void DisplayAddress()
    {
        Console.WriteLine(_streetAddress);
        Console.WriteLine($"{_city}, {_stateOrProvince}");
        Console.WriteLine(_country);
    }
}