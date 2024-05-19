/* +---------------------------------------+
   | Jamie Cummings                        |
   | CSE 210 Week 02                       |
   | Stretch exercise: I added some logic  |
   | to make sure the PromptGenerator      |
   | doesn't repeat Prompts. At the moment | 
   | it only works on new files. If you    |
   | load a file, you might get repeats of | 
   | prompts when you add more enties.     |
   +---------------------------------------+ */

using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "0";
        PromptGenerator promptList = new PromptGenerator();

        Journal myJournal = new Journal();
        string fileName = "Journal.txt";
        
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
                    //Console.WriteLine("Choice 1 selected.");
                    string randomPrompt = promptList.GetRandomPrompt();
                    Entry newEntry = new Entry();
                    DateTime theCurrentTime = DateTime.Now;
                    newEntry._date = theCurrentTime.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
                    newEntry._promptText = randomPrompt;
                    newEntry.Display();
                    newEntry._entryText = Console.ReadLine();
                    //newEntry._entryText = "A test entry.";

                    myJournal.AddEntry(newEntry);
                    break;
                case "2":
                    Console.WriteLine("Current Entries:");
                    myJournal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("What filename do you wish to load?");
                    fileName = Console.ReadLine();
                    Console.WriteLine($"Loading {fileName}...");
                    myJournal.LoadFromFile(fileName);
                    break;
                case "4":
                    Console.WriteLine("What is the file name you want to save to?");
                    fileName = Console.ReadLine();
                    Console.WriteLine($"Saving to {fileName}\n...Saved.");
                    myJournal.SaveToFile(fileName);
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