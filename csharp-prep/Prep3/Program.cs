using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";

        while (play == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            Console.WriteLine(number);

            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            int guess = int.Parse(userInput);

            while (guess != number)
            {
                if (guess < number)
                {
                    Console.WriteLine("Higher.");
                    Console.Write("What is your guess? ");
                    string newGuess = Console.ReadLine();
                    guess = int.Parse(newGuess);
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower.");
                    Console.Write("What is your guess? ");
                    string newGuess = Console.ReadLine();
                    guess = int.Parse(newGuess);
                }
            }
            Console.WriteLine("Congradulations! You guessed the number.");
            Console.Write("Do you want to play again? (yes or no)? ");
            play = Console.ReadLine();
        }
    }
}