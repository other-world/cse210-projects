using System.ComponentModel.DataAnnotations;

public class Cycling : Activity
{
    private double _speed; //in MPH
    private string _activityType;
    public Cycling(double speed, int length, string date) : base (length, date)
    {
        _speed = speed;
        _length = length;
        _date = date;
        _activityType = "Cycling";
    }

    public override double GetDistance()
    {
        double time = _length / 60;
        double distance = _speed * time;
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        double pace = _length / GetDistance();
        return pace;
    }
    
}