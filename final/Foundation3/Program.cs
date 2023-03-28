using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inheritance with Event Planning.");

        Address birthdayAddress = new Address("Street Address", "City", "State or Province", "Country");
        Event event1 = new Event("Event Title", "Description", "Date", "Time", birthdayAddress);
        string birthdayStandardDetails = event1.StandardDetails();
        string birthdayFullDetails = event1.FullDetails();
        string birthdayShortDescription = event1.ShortDescription();

        Address weddingAddress = new Address("1294 south 460 north", "Charlston", "New York", "USA");
        Reception reception = new Reception("Wedding", "Brittany and Scott's wedding reception", "June 27th 2023", "7:00pm - 10:00pm", weddingAddress, "brittany&scott@gmail.com");
        string weddingStandardDetails = reception.StandardDetails();
        string weddingFullDetails = reception.FullDetails();
        string weddingShortDescription = reception.ShortDescription();

        Address lectureAddress = new Address("1900 cambridge lane", "Boston", "Massachusetts", "USA");
        Lecture lecture = new Lecture("Clean Energy", "How we can change our city by using clean energy", "May 16th 2023", "1:00pm - 2:00pm", lectureAddress, "Sally Hope", 5000);
        string lectureStandardDetails = lecture.StandardDetails();
        string lectureFullDetails = lecture.FullDetails();
        string lectureShortDescription = lecture.ShortDescription();

        Address teaPartyAddress = new Address("1444 Brookbridge drive", "Lexington", "California", "USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Tea Party", "Tea Party to celebrate the coming spring", "April 5th 2023", "10:00am - 1:00pm", teaPartyAddress, "Sunny");
        string teaPartyStandardDetails = outdoorGathering.StandardDetails();
        string teaPartyFullDetails = outdoorGathering.FullDetails();
        string teaPartyShortDescription = outdoorGathering.ShortDescription();
        
        Console.WriteLine("Marketing Message:");
        Console.WriteLine($"Standard Details: {birthdayStandardDetails}");
        Console.WriteLine($"Full Details: {birthdayFullDetails}");
        Console.WriteLine($"Short Description: {birthdayShortDescription}");
        Console.WriteLine();

        Console.WriteLine("Wedding Reception");
        Console.WriteLine(weddingStandardDetails);
        Console.WriteLine(weddingFullDetails);
        Console.WriteLine(weddingShortDescription);
        Console.WriteLine();

        Console.WriteLine("Clean Energy Lecture");
        Console.WriteLine(lectureStandardDetails);
        Console.WriteLine(lectureFullDetails);
        Console.WriteLine(lectureShortDescription);
        Console.WriteLine();

        Console.WriteLine("Tea Party Outdoor Gathering");
        Console.WriteLine(teaPartyStandardDetails);
        Console.WriteLine(teaPartyFullDetails);
        Console.WriteLine(teaPartyShortDescription);
        Console.WriteLine();

    }
}