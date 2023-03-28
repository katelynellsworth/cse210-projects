public class ChecklistGoal : Goal
{
    private int _bonus = 0;
    private int _timesToComplete = 0;
    private int _timesCompleted = 0;
    public ChecklistGoal(string name, string description, int points, int bonus, int timesToComplete, int timesCompleted) : base(name, description, points)
    {
        _bonus = bonus;
        _timesToComplete = timesToComplete;
        _timesCompleted = timesCompleted;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    public int GetGoalAmount()
    {
        return _timesToComplete;
    }
    public void SetGoalAmount(int goalAmount)
    {
        _timesToComplete = goalAmount;
    }
    public override string DisplayGoal()
    {
        if (_timesCompleted >= _timesToComplete)
        {
            string name = base.GetName();
            string description = base.GetDescription();
            return $"[x] {name} ({description}) -- Currently completed: {_timesCompleted}/{_timesToComplete}";
        }
        else
        {
            string goal = base.DisplayGoal();
            return $"{goal} -- Currently completed: {_timesCompleted}/{_timesToComplete}";
        }
    }
    public override string SaveToFile()
    {
        return $"Checklist Goal_{GetName()}_{GetDescription()}_{GetPoints()}_{_bonus}_{_timesToComplete}_{_timesCompleted}";
    }
    public override int RecordEvent(int totalPoints)
    {
        _timesCompleted ++;

        int currentPoints = totalPoints + GetPoints();

        if (_timesCompleted == _timesToComplete)
        {
            currentPoints += _bonus;
            return currentPoints;
        }
        else
        {
            return currentPoints;
        }
    }


}