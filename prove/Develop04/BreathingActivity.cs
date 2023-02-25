public class BreathingActivity : Activity
{
    private string _breatheIn = "Breathe in...";
    private string _breatheOut = "Now breathe out...";

    public BreathingActivity() : base(activityName: "Breathing Activity", description: "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    override public void RunActivity()
    {
        base.RunBeggining();
        int seconds = GetSecondsForActivity();

        while (seconds <= 0)
        {
            Console.Write(_breatheIn);
            CountdownNumbers(4);

            Console.Write(_breatheOut);
            CountdownNumbers(8);

            seconds -= 12;
        }
        
        base.RunEnding();
    }
}