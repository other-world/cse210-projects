using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration = 0; // in seconds

    public Activity()
    {
        _name = "Activity";
        _description = "Parent Activity";
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        Animate(2);
        Console.Clear();
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Animate(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
    }

    public void Animate(int length)
    {
        int animateTurn = 500;
        for (int i=0; i < length; i++)
        {
            Console.Write("\\");
            Thread.Sleep(animateTurn);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(animateTurn);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(animateTurn);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(animateTurn);
            Console.Write("\b \b");
    }

        Console.WriteLine();
    }

}