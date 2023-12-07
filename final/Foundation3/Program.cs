using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");
        Address _address1 = new Address("125 Sesame Street", "New York City", "New York", "USA");
        Address _address2 = new Address("1333 West Georgia Street", "Vancouver", "British Columbia", "Canada");
        Address _address3 = new Address("525 S Center Street", "Rexburg", "Idaho", "USA");

        //Create a Lecture
        Lecture _lecture = new Lecture("Weekly Devotional", "The weekly devotional held in the BYU Idaho Center at BYU Idaho", "20231205", "11:30MT", _address3, "Roger Nichols", 25000);
        //And a Reception
        Reception _reception = new Reception("The joining of Grundgetta and Oscar", "Join us for the union of our resident grouches, Oscar and Grundgetta", "19970723", "17:00CT", _address1, "(208) 373-7220");
        //Can't forget our outdoor gathering!
        OutdoorGathering _outdoorGathering = new OutdoorGathering("Neighborhood Block Party", "Join us for a block party sponsored by the Phoenix Foundation!", "19920425", "19:00PT", _address2, "cloudy with a refreshing breeze.");

        //Test the Lecture
        Console.WriteLine("Lecture\nShort Description:\n" + _lecture.GetShortDescription() + "\nStandard Details:\n" + _lecture.GetStandardDetails() + "\nFull Details:\n" + _lecture.GetFullDetails());
        //Test the Reception
        Console.WriteLine("Reception\nShort Description:\n" + _reception.GetShortDescription() + "\nStandard Details:\n" + _reception.GetStandardDetails() + "\nFull Details:\n" + _reception.GetFullDetails());
        //Test the Outdoor Gathering
        Console.WriteLine("Outdoor Gathering\nShort Description:\n" + _outdoorGathering.GetShortDescription() + "\nStandard Details:\n" + _outdoorGathering.GetStandardDetails() + "\nFull Details:\n" + _outdoorGathering.GetFullDetails());

    }
}