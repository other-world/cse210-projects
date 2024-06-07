public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override void DisplayFullDetails()
    {
        Console.WriteLine(GetStandardDetails());

        Console.WriteLine("----------------------------");
        Console.WriteLine("  Event: Lecture");
        Console.WriteLine($"  Speaker: {_speaker}");
        Console.WriteLine($"  Event Capacity: {_capacity}");
        Console.WriteLine("----------------------------");
    }
    public override void DisplayShortDescription()
    {
        //Lists the type of event, title, and the date.
        Console.WriteLine();
        Console.WriteLine("----------------------------");
        Console.WriteLine("Event: Lecture");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine("----------------------------");
    }
    

}