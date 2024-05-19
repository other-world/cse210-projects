public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void Display()
    {   
        foreach (string prompt in _prompts)
        {
            Console.WriteLine($"{prompt}");
        }
    }

    public string GetRandomPrompt()
    {
        var random = new Random();
        string randomPrompt = "";
        if (_prompts.Count!=0){
            int index = random.Next(_prompts.Count);
            randomPrompt = _prompts[index];
            _prompts.Remove(randomPrompt);
        }
        //Console.WriteLine(randomPrompt);
        else 
        {
            randomPrompt = "What else would you like to record about your day?";
        }
        return randomPrompt;
    }

}