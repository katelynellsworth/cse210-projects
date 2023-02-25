public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<int> _availableQuestionsIndex = new List<int>();

    public ReflectingActivity() : base(activityName: "Reflecting Activity", description: "This activity will help you reflect on the times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = CreatePromptList();
        _questions = CreateQuestionList();
        _availableQuestionsIndex = CreateAvailableQuestionIndex();
    }
    private List<string> CreatePromptList()
    {
        List<string> prompts = new List<string>();

        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        return prompts;
    }
    private List<string> CreateQuestionList()
    {
        List<string> questions = new List<string>();

        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");

        return questions;
    }
    private string RandomPrompt()
    {
        Random random = new Random();
        int rnd = random.Next(0, _prompts.Count());

        string prompt = _prompts[rnd];

        return prompt;
    }
    private string RandomQuestion()
    {
        Random random = new Random();
        int rnd = random.Next(0, _questions.Count());

        int indexForQuestion = _availableQuestionsIndex[rnd];
        string question = _questions[indexForQuestion];

        return question;
    }
    private List<int> CreateAvailableQuestionIndex()
    {
        List<int> availableQuestionsIndex = new List<int>();

        for (int i = 0; i < _questions.Count(); i++)
        {
            availableQuestionsIndex.Add(i);
        }

        return availableQuestionsIndex;
    }
    override public void RunActivity()
    {
        base.RunBeggining();
        int seconds = GetSecondsForActivity();

        Console.WriteLine("Consider the following prompt:");
        string prompt = RandomPrompt();
        Console.WriteLine($"----{prompt}----");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Write("");

        Console.WriteLine("");
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        CountdownNumbers(5);

        Console.Clear();

        while (seconds <= 0)
        {
            Console.Write(RandomQuestion());
            CountdownNumbers(10);

            if (_availableQuestionsIndex.Count() <= 0)
            {
                seconds = 0;
            }
            else if (_availableQuestionsIndex.Count() > 0)
            {
                seconds -= 10;
            }
        }

        base.RunEnding();
    }

}