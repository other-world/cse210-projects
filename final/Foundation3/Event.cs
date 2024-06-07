public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title       = title;
        _description = description;
        _date        = date;
        _time        = time;
        _address     = address;
    }
    
    public string GetStandardDetails()
    {
        //Lists the title, description, date, time, and address.
        string standardDetails = $"{_title}\n----------------------------\n{_description}\n{_date}, {_time}\n----------------------------\nGetAddress()";
        return standardDetails;
    }
    public void DisplayStandardDetails()
    {
        Console.WriteLine(GetStandardDetails());
    }
    public abstract void DisplayFullDetails();

    public abstract void DisplayShortDescription();

    public string GetAddress()
    {
        return _address.GetAddress();
    }

}