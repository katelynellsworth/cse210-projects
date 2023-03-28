class Reception : Event
{
    private string _emailRSVP = "";
    public Reception(string title, string description, string date, string time, Address address, string emailRSVP) : base(title, description, date, time, address)
    {
        _emailRSVP = emailRSVP;
    }
    public string GetEmailRSVP()
    {
        return _emailRSVP;
    }
    public void SetEmailRSVP(string emailRSVP)
    {
        _emailRSVP = emailRSVP;
    }
    public override string FullDetails()
    {
        string string1 = base.FullDetails();
        return $"{string1} - {_emailRSVP}";
    }
    public override string ShortDescription()
    {
        return $"Reception - {base.GetTitle()} - {base.GetDescription()}";
    }
}