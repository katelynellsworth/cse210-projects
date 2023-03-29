abstract class Activity
{
    private string _date = "";
    private double _lengthInMinutes = 0;
    public Activity()
    {
    }
    public Activity(string date, double lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public double GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }
    public void SetLengthInMinutes(double lengthInMinutes)
    {
        _lengthInMinutes = lengthInMinutes;
    }
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public abstract string GetSummary();
}