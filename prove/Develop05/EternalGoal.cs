using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

public class EternalGoal : Goal
{
    private bool _isComplete;

    public EternalGoal(string shortName, string description, string points, bool isComplete) : base (shortName, description, points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public override void RecordEvent()
    {

    }
    public override bool isComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal::{_shortName}::{_description}::{_points}::{_isComplete}\n";
    }
    public override int GetBonus()
    {
        return 0;
    }

}