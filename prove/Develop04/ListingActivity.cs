public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity()
    {
        _count=0;
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in...");
        for (int countdown=5; countdown>0; countdown--) 
        { 
            Console.Write($"{countdown}"); 
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();

        List<string> userList = new List<string>(GetListFromUser());
        
        Console.WriteLine($"You've listed {userList.Count} items!");
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        var random = new Random();
        string randomPrompt = " --- ";
        if (_prompts.Count!=0){
            int index = random.Next(_prompts.Count);
            randomPrompt += _prompts[index];
            _prompts.Remove(randomPrompt);
        }
        //Console.WriteLine(randomPrompt);
        else 
        {
            randomPrompt += "";
        }
        randomPrompt += " ---";
        Console.WriteLine(randomPrompt);
    }
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        string addString = "";
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while  (DateTime.Now < endTime)
         {
            Console.Write(" > ");
            addString = Console.ReadLine();
            responses.Add(addString);
         }

        return responses;
    }

}