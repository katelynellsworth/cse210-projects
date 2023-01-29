using System.IO;

public class Program
{
    static List<Entry> journal = new List<Entry>();

    static void CreateNewEntry()
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
    static void DisplayJounal(List<Entry> entryList)
    {
        Console.WriteLine("Display all entrys in jounal.");

        foreach (Entry entry in entryList)
        {
            string prompt = entry.get_prompt();
            string date = entry.get_date();
            string response = entry.get_promptResponse();

            Console.WriteLine($"{date} - {prompt}");
            Console.WriteLine(response);
        }
    }
    static void LoadFile()
    {
        Console.WriteLine("Load past journal using file name.");

        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string dateText = parts[0];
            string prompt = parts[1];
            string response = parts[2];
        }
    }
    static void SaveFile(List<Entry> entryList)
    {
        Console.WriteLine("Save journal to file.");

        Console.Write("What is filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
           foreach (Entry entry in entryList)
           {
                string prompt = entry.get_prompt();
                string date = entry.get_date();
                string response = entry.get_promptResponse();
                
                outputFile.WriteLine(date, prompt, response);
           } 
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello to the Journal Program!");
        string reply = "";
        
        while (reply != "5")
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            reply = Console.ReadLine();

            if (reply == "1")
            {
                CreateNewEntry();
            }
            else if (reply == "2")
            {
                DisplayJounal(journal);
            }
            else if (reply == "3")
            {
                LoadFile();
            }
            else if (reply == "4")
            {
                SaveFile(journal);
            }
            else if (reply == "5")
            {
                reply = "5";
            }
            else{
                Console.WriteLine("Not valid input.");
            }
        }
    }
}