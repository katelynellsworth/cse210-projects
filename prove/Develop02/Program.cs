using System.IO;

public class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello to the Journal Program!");
        string reply = "";

        Journal journal = new Journal();
        
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
                journal.CreateNewEntry();
            }
            else if (reply == "2")
            {
                journal.DisplayJounal();
            }
            else if (reply == "3")
            {
                journal.LoadFile();
            }
            else if (reply == "4")
            {
                journal.SaveFile();
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