public class Activity
{
    private string _startingMessage = "";
    private string _activityName = "";
    private string _description = "";
    private int _secondsForActivity = 0;
    private string _countQuestion = "How long, in seconds, would you like for your session? ";
    private string _endMessage = "";

    public Activity(string activityName, string description)
    {
        _startingMessage = $"Welcome to the {activityName}.";
        _activityName = activityName;
        _description = description;
        _endMessage = ($"You have completed another {_secondsForActivity} seconds of the {_activityName}.");
    }
    public virtual void RunActivity()
    {
        RunBeggining();
        RunEnding();
    }
    protected void RunBeggining()
    {
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get Ready...");
        SpinnerToBlank(5);
        Console.WriteLine("");
    }
    private int DisplayStartingMessage()
    {
        Console.WriteLine(_startingMessage);
        Console.WriteLine("");

        Console.WriteLine(_description);
        Console.WriteLine("");

        _secondsForActivity = AskForCount();
        _endMessage = ($"You have completed another {_secondsForActivity} seconds of the {_activityName}.");

        return _secondsForActivity;
    }
    private int AskForCount()
    {
        Console.Write(_countQuestion);
        string userInput = Console.ReadLine();
        int seconds = int.Parse(userInput);

        return seconds;
    }
    protected void RunEnding()
    {
        DisplayEndingMessage();

        Console.Clear();
    }
    private void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!");
        SpinnerToBlank(10);
        Console.WriteLine("");

        Console.WriteLine(_endMessage);
        SpinnerToBlank(10);
        Console.WriteLine("");
    }
    public void SpinnerToBlank(int timeToSpin)
    {
        int count = 0;

        while (count <= timeToSpin)
        {
            Console.Write("\\");
            
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");

            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(250);
            Console.Write("\b \b");

            count += 1;
        }
    }
    protected void CountdownNumbers(int startingNumber)
    {
        int num = startingNumber;

        while (num != 0)
        {
            Console.Write(num);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            num -= 1;
        }
    }
    public int GetSecondsForActivity()
    {
        return _secondsForActivity;
    }
    public DateTime GetTime()
    {
        DateTime startTime = DateTime.Now;
        return startTime;
    }
}