public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    
    public abstract bool isComplete();
    public virtual string GetDetailsString()
    {
        string checkbox;
        if (isComplete())
        {
            checkbox = "[x]";
        }
        else
        {
            checkbox = "[ ]";
        }
        string goalDetails = $"{checkbox} {_shortName} ({_description})";
        return goalDetails;
    }
    public abstract string GetStringRepresentation();

    public string GetPoints()
    {
        return _points;
    }
    public abstract int GetBonus();
    
    
    
}