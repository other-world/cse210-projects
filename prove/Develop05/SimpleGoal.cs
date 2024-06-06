public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, string points, bool isComplete) : base (shortName, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    
    }
    public override bool isComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal::{_shortName}::{_description}::{_points}::{_isComplete}\n";
    }
    public override int GetBonus()
    {
        return 0;
    }
}