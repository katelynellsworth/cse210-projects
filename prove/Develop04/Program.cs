using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

        while (userInput != "4")
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = Console.ReadLine();

            if (userInput == "1"){
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunActivity();
            }
            if (userInput == "2"){
                ReflectingActivity breathingActivity = new ReflectingActivity();
                breathingActivity.RunActivity();
            }
            if (userInput == "3"){
                ListingActivity breathingActivity = new ListingActivity();
                breathingActivity.RunActivity();
            }
            if (userInput == "4"){
                userInput = "4";
            }
        }
    }
}