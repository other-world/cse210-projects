public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    private int _counter;

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int counter) : base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _counter = counter;
    }

    public override void RecordEvent()
    {
        _counter += 1;
    }
    public override bool isComplete()
    {
        if (_counter == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
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
        string goalDetails = $"{checkbox} {_shortName} ({_description}) -- Currently completed {_counter}/{_target}";
        return goalDetails;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal::{_shortName}::{_description}::{_points}::{_target}::{_bonus}::{_counter}\n";
    }
    public override int GetBonus()
    {
        return _bonus;
    }
}