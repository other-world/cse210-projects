/* Jamie Cummings
CSE210 Week 03
Scripture Memorizer
Strech Challenge: Added logic to the Scripture 
class to always hide the nubmer of words 
specificed in HideRandomWords */

using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        string exit = "";
        Reference myReference = new Reference("Ether", 12, 26, 27);
        Scripture myScripture = new Scripture(myReference, "And when I had said this, the Lord spake unto me, saying: Fools mock, but they shall mourn; and my grace is sufficient for the meek, that they shall take no advantage of your weakness; And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        //Scripture myScripture = new Scripture(myReference, "And");
      

        while (exit != "quit")
        {
            Console.Clear();
            Console.WriteLine($"{myScripture.GetDisplayText()}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue to type 'quit' to exit:");
            exit = Console.ReadLine();

            if (myScripture.IsCompletelyHidden())
            {
                break;
            }
            else
            {
                myScripture.HideRandomWords(3);
            }
        }
        
    }
}