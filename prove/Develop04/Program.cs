/* Jamie Cummings
   CSE 210 Week 04 - Mindfullness Program
   For the stretch challenge I did a few things. 
   I set up code to make the prompts in the 
   Reflection Activity not repeat. I also set up 
   the animation as a method in the activity class. 
   The method takes an integer that determines 
   how many times the animation repeats. This 
   allows some variation in its use. */


using System;

class Program
{
    static void Main(string[] args)
    {
        string menuChoice = "0";
        while (menuChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu:");
            menuChoice = Console.ReadLine();
            
            
            switch(menuChoice)
            {
                case "1":
                    //Console.WriteLine("Choice 1");
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    //Console.WriteLine("Choice 2");
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Run();
                    break;
                case "3":
                    //Console.WriteLine("Choice 3");
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
            }
        }
    }
}