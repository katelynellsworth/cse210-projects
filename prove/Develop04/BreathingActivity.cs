public class BreathingActivity : Activity
{
    private string _breatheIn = "Breathe in...";
    private string _breatheOut = "Now breathe out...";

    public BreathingActivity() : base(activityName: "Breathing Activity", description: "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    override public void RunActivity()
    {
        Console.Clear();

        base.RunBeggining();
        int seconds = GetSecondsForActivity();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write(_breatheIn);
            CountdownNumbers(4);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write(_breatheOut);
            CountdownNumbers(8);
            Console.WriteLine("");
            Console.WriteLine("");

            currentTime = DateTime.Now;
        }
        
        base.RunEnding();
    }
}