using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 1;
        int sum = 0;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {


            Console.Write("Enter Number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);

            if (number != 0)
            {
                numbers.Add(number);
            }

            sum += number;
        }

        int len = numbers.Count;
        int average = sum / len;
        
        int max = 0;

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
            if (max < num)
            {
                max = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }
}