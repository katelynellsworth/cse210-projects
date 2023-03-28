class Event
{
    private string _title = "";
    private string _description = "";
    private string _date = "";
    private string _time = "";
    private Address _address = new Address();
    public Event()
    {
    }
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetTime()
    {
        return _time;
    }
    public void SetTime(string time)
    {
        _time = time;
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
    public string StandardDetails()
    {
        return $"{_title} - {_description} - {_date} - {_time} - {_address.CreateAddressString()}";
    }
    public virtual string FullDetails()
    {
        return $"{_title} - {_description} - {_date} - {_time} - {_address.CreateAddressString()}";
    }
    public virtual string ShortDescription()
    {
        return $"Event - {_title} - {_description}";
    }
}