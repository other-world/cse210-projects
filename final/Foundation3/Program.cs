using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program 3: Inheritance with Event Planning");
        /* Once you have the classes in place, write a program that 
        creates at least one event of each type and sets all of 
        their values. Then, for event event, call each of the 
        methods to generate the marketing messages and output their 
        results to the screen.*/

        // Event Lecture Demonstration
        Address address1 = new Address("60 North Temple", "Salt Lake City", "UT", 84150, "USA");
        Lecture lecture = new Lecture("All Things for Our Good", "In time and eternity, the purpose of Creation and the nature of God Himself are to bring all things together for our good.", "April 6, 2024", "9:00AM", address1, "Garrent Gong", 15000);

        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayFullDetails();
        Console.WriteLine();
        lecture.DisplayShortDescription();
        Console.WriteLine();
        Console.WriteLine();

        // Event Reception Demonstration

        Address address2 = new Address("123 Green Hill Rd.", "Provo", "UT", 84601, "USA");
        Reception reception = new Reception("Lilly and James Potter Reception", "Celebrating the wedding of Lilly and James Potter", "June 14, 2024", "11:00AM", address2, "evansfamily@gmail.com");

        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayFullDetails();
        Console.WriteLine();
        reception.DisplayShortDescription();
        Console.WriteLine();
        Console.WriteLine();

        Address address3 = new Address("Crater Edge Drive", "Burning Mountain", "FR", 87284, "Mustafar");
        OutdoorGathering outdoors = new OutdoorGathering("Skywalker Family Reunion", "We keep converting to the Dark Side, come celebrate before then.", "September 30, 2024", "Noon", address3, "Some Volcanic Activity");

        outdoors.DisplayStandardDetails();
        Console.WriteLine();
        outdoors.DisplayFullDetails();
        Console.WriteLine();
        outdoors.DisplayShortDescription();





    }
}