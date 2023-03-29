class Swimming : Activity
{
    private int _numberOfLaps = 0;
    public Swimming()
    {
    }
    public Swimming(string date, double lengthInMinutes, int numberOfLaps) : base(date, lengthInMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }
    public int GetNumberOfLaps()
    {
        return _numberOfLaps;
    }
    public void SetNumberOfLaps(int numberOfLaps)
    {
        _numberOfLaps = numberOfLaps;
    }
    public override double CalculateDistance()
    {
        double distance = _numberOfLaps * 50 / 1000 * 0.62;
        return distance;
    }
    public override double CalculateSpeed()
    {
        double speed = (_numberOfLaps * 50 * 60) / (base.GetLengthInMinutes() * 1609.34);
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = (_numberOfLaps * 50) / (base.GetLengthInMinutes() * 1609.34);
        return pace;
    }
    public override string GetSummary()
    {
        double length = base.GetLengthInMinutes();
        double roundedLength = Math.Round(length, 1);

        double roundedDistance = Math.Round(CalculateDistance(), 2);
        double roundedSpeed = Math.Round(CalculateSpeed(), 2);
        double roundedPace = Math.Round(CalculatePace(), 2);

        return $"{base.GetDate()} Swimming ({roundedLength} min)- Distance {roundedDistance} miles, Speed {roundedSpeed} mph, Pace: {roundedPace} min per mile";
    }
}