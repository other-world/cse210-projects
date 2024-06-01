public class BreathingActivity : Activity
{
    public BreathingActivity() : base ()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        //Console.WriteLine(startTime);
        //Console.WriteLine(endTime);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            for (int countdown=4; countdown>0; countdown--) 
            { 
                Console.Write($"{countdown}"); 
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
            Console.Write("Hold the inhale...");
            for (int countdown =4; countdown>0; countdown--) 
            { 
                Console.Write($"{countdown}"); 
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
            Console.Write("Now breathe out...");
            for (int countdown =4; countdown>0; countdown--) 
            { 
                Console.Write($"{countdown}"); 
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
            Console.Write("Hold the exhale...");
            for (int countdown =4; countdown>0; countdown--) 
            { 
                Console.Write($"{countdown}"); 
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }

        DisplayEndingMessage();


    }
}