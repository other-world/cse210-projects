using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignmentTest = new Assignment("Jamie Cummings", "Algebra");
        Console.WriteLine(assignmentTest.GetSummary());
        //MathAssignment mathHomework = new MathAssignment("Jamie Cummings", "Algebra", "Section 7.2", "13-29");
        //Console.WriteLine(mathHomework.GetSummary());
    }
}