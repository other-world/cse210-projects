public class Address
{
    private string _street;
    private string _city;
    private string _stateProv;
    private int _zipcode;
    private string _country;

    public Address (string street, string city, string stateProv, int zipcode, string country)
    {
        _street = street;
        _city = city;
        _stateProv = stateProv; 
        _zipcode = zipcode;
        _country = country;
    }

    public bool usAddress()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_stateProv} {_zipcode}\n{_country}";
    }
    public void DisplayAddress()
    {
        Console.WriteLine($"{_street}\n{_city}, {_stateProv} {_zipcode}\n{_country}");
    }
}