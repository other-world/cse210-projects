public class Reception : Event
{
    private string _email; // Reception only

    public Reception(string title, string description, string date, string time, Address address, string email) : base (title, description, date, time, address)
    {
        _email = email;
    }
    public override void DisplayFullDetails()
    {
        Console.WriteLine(GetStandardDetails());

        Console.WriteLine("----------------------------");
        Console.WriteLine("  Event: Reception");
        Console.WriteLine($"  Please RSVP at {_email}");
        Console.WriteLine("----------------------------");

    }
    public override void DisplayShortDescription()
    {
        Console.WriteLine();
        Console.WriteLine("----------------------------");
        Console.WriteLine("Event: Reception");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine("----------------------------");
    }
}