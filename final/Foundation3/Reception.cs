public class Reception : Event
{
    private string _email; // Reception only

    public Reception(string title, string description, string date, string time, string address, string email) : base (title, description, date, time, address)
    {
        _email = email;
    }
}