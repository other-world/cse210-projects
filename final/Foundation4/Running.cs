public class Running : Activity
{
    private double _distance; // in miles
    private string _activityType;
    public Running(double distance, int length, string date) : base (length, date)
    {
        _distance     = distance;
        _length      = length;
        _date         = date;
        _activityType = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed() //
    {
        double speed = _length / _distance;
        return speed;
    }
    public override double GetPace()
    {
        double pace = _length / _distance;
        return pace;
    }
}