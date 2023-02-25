public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    public ListingActivity() : base(activityName: "Listing Activity", description: "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = CreatePromptList();
    }
    private List<string> CreatePromptList()
    {
        List<string> prompts = new List<string>();

        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");

        return prompts;
    }
    override public void RunActivity()
    {
        base.RunBeggining();
        int seconds = GetSecondsForActivity();
        int count = 0;

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"----{RandomPrompt()}----");
        Console.Write("You may begin in: ");
        CountdownNumbers(5);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();

            count += 1;

            currentTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {count} items!");
        Console.WriteLine("");
        
        base.RunEnding();
    }
    private string RandomPrompt()
    {
        Random random = new Random();
        int rnd = random.Next(0, _prompts.Count());

        string prompt = _prompts[rnd];

        return prompt;
    }
}