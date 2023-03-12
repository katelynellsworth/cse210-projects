public class SimpleGoal : Goal
{
    private string _isCompleted = "false";
    public SimpleGoal(string name, string description, int points, string isCompleted) : base(name, description, points)
    {
        _isCompleted = isCompleted;
    }
    public override string DisplayGoal()
    {
        if (_isCompleted == "false")
        {
            return $"[ ] {GetName()} ({GetDescription()})";
        }
        else if (_isCompleted == "true")
        {
            return $"[x] {GetName()} ({GetDescription()})";
        }
        else
        {
            return "";
        }
    }
    public override string SaveToFile()
    {
        return $"Simple Goal_{GetName()}_{GetDescription()}_{GetPoints()}_{_isCompleted}";
    }
    public override int RecordEvent(int totalPoints)
    {
        _isCompleted = "true";

        int currentPoints = totalPoints + GetPoints();
        return currentPoints;
    }
}