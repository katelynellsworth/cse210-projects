using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        List<Goal> _goals = new List<Goal>();

        string userInput = "1";

        while (userInput != "6")
        {
            Console.WriteLine("");
            Console.WriteLine("You have 0 points.");
            Console.WriteLine("");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("The type of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("What type of goal would you like to create? ");

                string userGoalSelection = Console.ReadLine();

                if (userGoalSelection == "1")
                {
                    string name = program.CreateGoalName();
                    string description = program.CreateGoalDescription();
                    int points = program.CreateGoalPoints();

                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points, "false");
                    _goals.Add(simpleGoal);
                }
                else if (userGoalSelection == "2")
                {
                    string name = program.CreateGoalName();
                    string description = program.CreateGoalDescription();
                    int points = program.CreateGoalPoints();

                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                }
                else if (userGoalSelection == "3")
                {
                    string name = program.CreateGoalName();
                    string description = program.CreateGoalDescription();
                    int points = program.CreateGoalPoints();
                    int amount = program.CreateGoalAmount();
                    int bonus = program.CreateGoalBonus();
                
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonus, amount, 0);
                    _goals.Add(checklistGoal);
                }
            }
            else if (userInput == "2")
            {
                program.DisplayGoals(_goals);
            }
            else if (userInput == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                program.SaveFile(filename, _goals);
            }
            else if (userInput == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                _goals = program.FileToList(filename);
            }
            else if (userInput == "5")
            {
                var i = 0;
                var count = 1;
                foreach (Goal goal in _goals)
                {
                    string display = $"{count}.{goal.DisplayGoal()}";

                    count ++;
                    i ++;
                }
                Console.Write("Which goal did you accomplish? ");
                string userNum = Console.ReadLine();
                int num = Int32.Parse(userNum);
            }
            else if (userInput == "6")
            {
                userInput = "6";
            }
        }
    }
    private string CreateGoalName()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        return name;
    }
    private string CreateGoalDescription()
    {
        Console.Write("What is a short description of the goal? ");
        string description = Console.ReadLine();
        return description;
    }
    private int CreateGoalPoints()
    {
        Console.WriteLine("What is the amount of points associated with this goal? ");
        string stringPoints = Console.ReadLine();
        int points = Int32.Parse(stringPoints);
        return points;
    }
    private int CreateGoalBonus()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        string stringBonus = Console.ReadLine();
        int bonus = Int32.Parse(stringBonus);
        return bonus;
    }
    private int CreateGoalAmount()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string stringAmomunt = Console.ReadLine();
        int amount = Int32.Parse(stringAmomunt);
        return amount;
    }
    private void DisplayGoals(List<Goal> _goals)
    {
        var count = 1;
        Console.WriteLine("The Goals are:");

        foreach (Goal goal in _goals)
        {
            string display = $"{count}.{goal.DisplayGoal()}";
            count ++;
        }
    }
    public void SaveFile(string filename, List<Goal> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.SaveToFile());
            }
        }
    }
    private List<Goal> FileToList(string filename)
    {
        List<Goal> _goals = new List<Goal>();

        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            string [] parts = line.Split("_");

            string goalName = parts[0];
            string name = parts[1];
            string description = parts[2];
            string stringPoints = parts[3];
            int points = Int32.Parse(stringPoints);

            if (goalName == "Simple Goal")
            {
                string isCompleted = parts[4];
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isCompleted);
                _goals.Add(simpleGoal);
            }
            else if (goalName == "Eternal Goal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            else if (goalName == "Checklist Goal")
            {
                string stringBonus = parts[4];
                int bonus = Int32.Parse(stringBonus);
                string stringTimesToComplete = parts[5];
                int timesToComplete = Int32.Parse(stringTimesToComplete);
                string stringTimesCompleted = parts[6];
                int timesCompleted = Int32.Parse(stringTimesCompleted);

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonus, timesToComplete, timesCompleted);
                _goals.Add(checklistGoal);
            }
        }
        return _goals;
    }
}