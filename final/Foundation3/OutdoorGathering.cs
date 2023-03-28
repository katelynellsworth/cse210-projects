class OutdoorGathering : Event
{
    private string _weather = "";
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }
    public string GetWeather()
    {
        return _weather;
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }
    public override string FullDetails()
    {
        string string1 = base.FullDetails();
        return $"{string1} - Weather: {_weather}";
    }
    public override string ShortDescription()
    {
        return $"Outdoor Gathering - {base.GetTitle()} - {base.GetDescription()}";
    }
}