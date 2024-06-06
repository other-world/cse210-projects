using System.Collections;
using System.Diagnostics.Metrics;
using System.Security.AccessControl;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private string _level = "";

    public GoalManager()
    {
        _score = 0;
    }
    public void Start()
    {
        Console.WriteLine("Welcome to the GoalManager!");
        string userChoice = "0";

        while (userChoice != "6")
        {
            DisplayPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Choice 1 selected.");
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Have a great day!");
                    break;
                default:
                    Console.WriteLine("Selection not recognized. Please try again.");
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current points are {_score}.");
        Console.WriteLine($"Your current level is {GetLevel()}.");

    }
    public void ListGoalNames()
    { /*  
        int counter=0;
        foreach(Goal goal in _goals)
        {
            counter += 1;
            Console.WriteLine($"{counter}. {goal.GetStringRepresentation()}");
        }*/
    }
    public void ListGoalDetails()
    {
        int counter = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{counter}. {goal.GetDetailsString()}");
            counter ++;
        }
    }
    public void CreateGoal()
    {
        string userChoice = "0";
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("What type of goal would you like to make? ");
        userChoice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string goalDescription = Console.ReadLine();
        Console.Write("How many points is this goal? ");
        string goalPoints = Console.ReadLine();

        switch (userChoice)
        {
            case "1":
                //Console.WriteLine("Simple Goal selected.");
                SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, false);
                _goals.Add(newSimpleGoal);
                break;
            case "2":
                //Console.WriteLine("Eternal Goal Selected:");
                EternalGoal newEternalGoal = new EternalGoal(goalName, goalDescription, goalPoints, false);
                _goals.Add(newEternalGoal);
                break;
            case "3":
                Console.Write("How many times does this need to be accomplished to receive a bonus?");
                int target = Int32.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Checklist Goal Selected");
                ChecklistGoal newChecklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus, 0);
                _goals.Add(newChecklistGoal);
                break;
            default:
                Console.WriteLine("Selection not recognized. Returning to main menu.");
                break;
        }
    }
    public void RecordEvent()
    {
        int markGoal; 
        Console.WriteLine("The goals are:");
        int goalCounter = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goalCounter}. {goal.GetDetailsString()}");
            goalCounter ++;
        }
        Console.Write("Which goal did you accomplish? ");
        markGoal = Int32.Parse(Console.ReadLine()) -1;
        _goals[markGoal].RecordEvent();
        Console.WriteLine($"Congratulations, you earned {_goals[markGoal].GetPoints()} points!");
        _score += Int32.Parse(_goals[markGoal].GetPoints());
        if (_goals[markGoal].isComplete())
        {
            Console.WriteLine($"Congratulations, you get a bonus of {_goals[markGoal].GetBonus()} points!");
            _score += _goals[markGoal].GetBonus();
        }
    }
    public string GetLevel()
    {
        if (_score < 100)
        {
            _level = "Grub Worm";
        }
        else if (_score >=100 && _score < 500)
        {
            _level = "Grasshopper";
        }
        else if (_score >=500 && _score < 1000)
        {
            _level = "Apprentice";
        }
        else if (_score >=1000 && _score < 5000)
        {
            _level = "Journeyman";
        }
        else if (_score >=5000 && _score < 10000)
        {
            _level = "Master";
        }
        else if (_score >= 10000)
        {
            _level = "Guru";
        }
        return _level;
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the file name you want to save to?");
        string fileName = Console.ReadLine();
        Console.WriteLine($"Saving to {fileName}\n...Saved.");
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.Write($"{_score}\n");
            foreach (Goal goal in _goals)
            {
                outputFile.Write($"{goal.GetStringRepresentation()}");
            }
            
        }

    }
    public void LoadGoals()
    {
        _goals.Clear();
        Console.Write("What is the filename for the goal file you want to load? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines) 
        {
            //Console.WriteLine($"{line}");
            string[] parts = line.Split("::");
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal loadedGoal = new SimpleGoal(parts[1], parts[2], parts[3], bool.Parse(parts[4]));
                _goals.Add(loadedGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal loadedGoal = new EternalGoal(parts[1], parts[2], parts[3], bool.Parse(parts[4]));
                _goals.Add(loadedGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal loadedGoal = new ChecklistGoal(parts[1], parts[2], parts[3], Int32.Parse(parts[4]), Int32.Parse(parts[5]), Int32.Parse(parts[6]));
                _goals.Add(loadedGoal);
            }
            else
            {
                _score = Int32.Parse(parts[0]);
            }
            
            
        }
    }
}