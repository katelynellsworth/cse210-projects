public class Goal
{
    private string _name = "";
    private string _description = "";
    private int _points = 0;
    private string _complete = "false";
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string discription)
    {
        _description = discription;
    }

    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public virtual string DisplayGoal()
    {
        if (_complete == "false")
        {
            return $"[ ] {_name} ({_description})";
        }
        else 
        {
            return $"[x] {_name} ({_description})";
        }
    }
    public virtual string SaveToFile()
    {
        return $"[ ] {_name} ({_description})";
    }
    public virtual int RecordEvent(int totalPoints)
    {
        _complete = "true";

        int currentPoints = totalPoints + _points;
        return currentPoints;
    }
}