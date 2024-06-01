using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignmentTest = new Assignment("Jamie Cummings", "Algebra");
        Console.WriteLine(assignmentTest.GetSummary());
        MathAssignment mathHomework = new MathAssignment("Cliff Cummings", "Algebra", "Section 7.2", "13-29");
        Console.WriteLine(mathHomework.GetSummary());
        Console.WriteLine(mathHomework.GetHomeworkList());
        WritingAssignment writingHomework = new WritingAssignment("Kristen Cummings", "English", "Watership Down");
        Console.WriteLine(writingHomework.GetSummary());
        Console.WriteLine(writingHomework.GetWritingInformation());
    }
}