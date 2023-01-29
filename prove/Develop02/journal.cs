class Journal
{
    List<Entry> journal = new List<Entry>();

    public void CreateNewEntry()
    {
        Console.WriteLine("Write entry off of prompt.");
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.RandomPrompt();

        Console.WriteLine(prompt);
        Console.Write("> ");
        string userInput = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Entry entry = new Entry(prompt, userInput, dateText);
        journal.Add(entry);   

        Console.WriteLine();
    }
    public void DisplayJounal()
    {
        Console.WriteLine("Display all entrys in jounal.");

        foreach (Entry entry in journal)
        {
            string prompt = entry.get_prompt();
            string date = entry.get_date();
            string response = entry.get_promptResponse();

            Console.WriteLine($"{date} - {prompt}");
            Console.WriteLine(response);
        }
    }
    public void LoadFile()
    {
        journal.Clear();

        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"{filename}");

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string dateText = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry(prompt, response, dateText);
            journal.Add(entry);
        }
    }
    public void SaveFile()
    {
        Console.WriteLine("Save journal to file.");

        Console.Write("What is filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
           foreach (Entry entry in journal)
           {
                string prompt = entry.get_prompt();
                string date = entry.get_date();
                string response = entry.get_promptResponse();
                
                outputFile.WriteLine($"{date}, {prompt}, {response}");
           } 
        }
    }
}