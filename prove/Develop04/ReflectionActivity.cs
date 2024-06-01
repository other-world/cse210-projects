public class ReflectionActivity : Activity
{
    public List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    public List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?", 
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        for (int countdown=5; countdown>0; countdown--) 
        { 
            Console.Write($"{countdown}"); 
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();
        // Since we've already taken about 5 seconds for the activity, 
        // subtract that from the duration
        _duration -= 5;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

         while (DateTime.Now < endTime)
         {
            DisplayQuestions();
            Animate(4);
         }
         DisplayEndingMessage();
    }

    public string GetRandomPrompt()
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
        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        var randomQ = new Random();
        string randomQuestion = "";
        if (_questions.Count!=0){
            int index = randomQ.Next(_questions.Count);
            randomQuestion = _questions[index];
            _questions.Remove(randomQuestion);
        }
        else 
        {
            randomQuestion = "";
        }
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}