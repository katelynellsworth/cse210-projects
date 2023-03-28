public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override string DisplayGoal()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }
    public override string SaveToFile()
    {
        return $"Eternal Goal_{GetName()}_{GetDescription()}_{GetPoints()}";
    }
    public override int RecordEvent(int totalPoints)
    {
        int currentPoints = totalPoints + GetPoints();
        return currentPoints;
    }

}