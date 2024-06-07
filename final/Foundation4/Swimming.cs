public class Swimming : Activity
{
    double _laps;
    private string _activityType;

    public Swimming(double laps, int length, string date) : base (length, date)
    {
        _laps = laps;  // distance is entered as # of Laps
        _length = length;
        _date = date;
        _activityType = "Swimming";
    }

    public override double GetDistance()
    {
        // Distance (miles) = swimming laps * 50 / 1000 * 0.62
        double distance = _laps * 50 / 1000 * 0.62;
        return distance;
    }
    public override double GetSpeed()
    {
        double speed = (GetDistance() / _length) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double _pace = _length / GetDistance();
        return _pace;

    }
}