class Running : Activity
{
    private double _distanceInMiles = 0;
    public Running()
    {
    }
    public Running(string date, double lengthInMinutes, double distanceInMiles) : base(date, lengthInMinutes)
    {
        _distanceInMiles = distanceInMiles;
    }
    public double GetDistance()
    {
        return _distanceInMiles;
    }
    public void SetDistance(double distanceInMiles)
    {
        _distanceInMiles = distanceInMiles;
    }
    public override double CalculateDistance()
    {
        return _distanceInMiles;
    }
    public override double CalculateSpeed()
    {
        double speed = (_distanceInMiles / base.GetLengthInMinutes()) * 60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = base.GetLengthInMinutes() / _distanceInMiles;
        return pace;
    }
    public override string GetSummary()
    {
        double length = base.GetLengthInMinutes();
        double roundedLength = Math.Round(length, 1);

        double roundedDistance = Math.Round(_distanceInMiles, 1);
        double roundedSpeed = Math.Round(CalculateSpeed(), 1);
        double roundedPace = Math.Round(CalculatePace(), 1);

        return $"{base.GetDate()} Running ({roundedLength} min)- Distance {roundedDistance} miles, Speed {roundedSpeed} mph, Pace: {roundedPace} min per mile";
        // return $"{base.GetDate()} Running ({base.GetLengthInMinutes} min)- Distance {_distance} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}