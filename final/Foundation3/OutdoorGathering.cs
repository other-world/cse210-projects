public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base (title, description, date, time, address)
    {
        _weather = weather;
    }
    public override void DisplayFullDetails()
    {
        Console.WriteLine(GetStandardDetails());

        Console.WriteLine("----------------------------");
        Console.WriteLine("  Event: Outdoor Gathering");
        Console.WriteLine("  Current Weather Forecast:");
        Console.WriteLine($"  {_weather}");
        Console.WriteLine("----------------------------");

    }
    public override void DisplayShortDescription()
    {
        Console.WriteLine();
        Console.WriteLine("----------------------------");
        Console.WriteLine("Event: Outdoor Gathering");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine("----------------------------");
    }
}