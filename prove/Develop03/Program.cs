using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Scripture Memorize World!");

        Scripture scripture = new Scripture("Ether", "12", "27", "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");

        string userInput = "";
        bool blank = false;

        while (userInput != "quit" && blank == false)
        {
            string display = scripture.DisplayWholeScripture();
            Console.WriteLine(display);
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            Console.Write(">");
            userInput = Console.ReadLine();
            if (userInput == "")
            {
                scripture.HideThreeRandomWords();
                blank = scripture.ScriptureHidden();
                if (blank == true)
                {
                    display = scripture.DisplayWholeScripture();
                    Console.WriteLine(display);
                }
            }
        }
    }
}