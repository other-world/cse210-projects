public abstract class Activity
{
    //protected double _distance;
    //protected double _speed;
    //protected double _pace;
    protected string _date;
    protected int _length; // in minutes
    private string _activityType = "";
    public Activity(int length, string date)
    {
        _length  = length;
        _date     = date;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        string summary = $"{_date} {_activityType} ({_length}) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile"; 
        return summary;
    }

}