class Cycling : Activity
{
    private double _speedInMPH = 0;
    public Cycling()
    {
    }
    public Cycling(string date, double lengthInMinutes, double speedInMPH) : base(date, lengthInMinutes)
    {
        _speedInMPH = speedInMPH;
    }
    public double GetSpeed()
    {
        return _speedInMPH;
    }
    public void SetSpeed(double speedInMPH)
    {
        _speedInMPH = speedInMPH;
    }
    public override double CalculateDistance()
    {
        double distance = (base.GetLengthInMinutes() / 60) * _speedInMPH;
        return distance;
    }
    public override double CalculateSpeed()
    {
        return _speedInMPH;
    }
    public override double CalculatePace()
    {
        double pace = 60 / _speedInMPH;
        return pace;
    }
    public override string GetSummary()
    {
        double length = base.GetLengthInMinutes();
        double roundedLength = Math.Round(length, 1);

        double roundedDistance = Math.Round(CalculateDistance(), 1);
        double roundedSpeed = Math.Round(CalculateSpeed(), 1);
        double roundedPace = Math.Round(CalculatePace(), 1);

        return $"{base.GetDate()} Cycling ({roundedLength} min)- Distance {roundedDistance} miles, Speed {roundedSpeed} mph, Pace: {roundedPace} min per mile";
    }
}