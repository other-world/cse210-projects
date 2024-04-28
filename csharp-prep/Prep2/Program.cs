using System;

class Program
{
    static void Main(string[] args)
    {
        string myGrade = "F";
        int remainder = 0;
        bool passFail = true;

        Console.WriteLine("Please enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int percentageAsInteger = int.Parse(gradePercentage);
        remainder = percentageAsInteger % 10;

        if (percentageAsInteger >= 90)
        {
            myGrade = "A";
            remainder = 5;
        }
        else if (percentageAsInteger >= 80 && percentageAsInteger < 90)
        {
            myGrade = "B";
        }
        else if (percentageAsInteger >= 70 && percentageAsInteger < 80)
        {
            myGrade = "C";
        }
        else if (percentageAsInteger >= 60 && percentageAsInteger < 90)
        {
            myGrade = "D";
        }
        else
        {
            myGrade = "F";
            remainder = 5;
        }

        if (remainder >= 7)
        {
            myGrade += "+";
        }
        else if (remainder <= 3)
        {
            myGrade += "-";
        }

        Console.WriteLine($"Your grade is: {myGrade}");
        //Console.WriteLine($"Remainder: {remainder}");

        if (percentageAsInteger >= 70)
        {
            Console.WriteLine("You passed. Congratulations!");
        }
        else
        {
            Console.WriteLine("You didn't pass the course. But if you work hard and try again, you can make it!");
        }

    }
}