class Lecture : Event
{
    private string _speakerName = "";
    private int _capacity = 0;
    public Lecture()
    {
    }
    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity) : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
    public string GetSpeakerName()
    {
        return _speakerName;
    }
    public void SetSpeakerName(string speakerName)
    {
        _speakerName = speakerName;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }
    public override string FullDetails()
    {
        string string1 = base.FullDetails();
        return $"{string1} - {_speakerName} - {_capacity}";
    }
    public override string ShortDescription()
    {
        return $"Lecture - {base.GetTitle()} - {base.GetDescription()}";
    }
}