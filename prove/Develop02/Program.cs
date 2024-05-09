using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "0";
        //Console.WriteLine("Hello Develop02 World!");
        PromptGenerator promptList = new PromptGenerator();
        //promptList.Display();
        string randomPrompt = promptList.GetRandomPrompt();
        //Console.WriteLine($"{randomPrompt}");

        Entry newEntry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        newEntry._date = theCurrentTime.ToShortDateString();
        newEntry._promptText = randomPrompt;
        newEntry._entryText = "A test entry.";
        newEntry.Display();
        while (userChoice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Choice 1 selected.");
                    break;
                case "2":
                    Console.WriteLine("Choice 2 selected.");
                    break;
                case "3":
                    Console.WriteLine("Choice 3 selected.");
                    break;
                case "4":
                    Console.WriteLine("Choice 4 selected.");
                    break;
                case "5":
                    Console.WriteLine("Have a great day!");
                    break;
                default:
                    Console.WriteLine("Selection not recognized. Please try again.");
                    break;
            }
        }


    }
}