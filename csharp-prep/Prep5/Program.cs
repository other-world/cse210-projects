using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string fullName = Console.ReadLine();
        return fullName;
    }

    static int PromptUserNumber()
    {
       Console.Write("Please enter your favorite number: ");
        int favoriteNum = int.Parse(Console.ReadLine()); 
        return favoriteNum;
    }

    static void DisplayResult()
    {
        string fullName = PromptUserName();
        int favoriteNum = PromptUserNumber();
        int numSquared = (int)Math.Pow(favoriteNum, 2);
        Console.WriteLine($"{fullName}, the square of your number is {numSquared}.");
    } 
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult();
    }
}