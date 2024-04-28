using System;

class Program
{
    static void Main(string[] args)
    {
        int guessAsInteger = 0;
        Console.WriteLine("What is the magic number?");
        string magicNumber = Console.ReadLine();
        int magicNumberAsInteger = int.Parse(magicNumber);

        while (guessAsInteger != magicNumberAsInteger)
        {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            guessAsInteger = int.Parse(guess);
            if (guessAsInteger < magicNumberAsInteger)
            {
                Console.WriteLine("Higher");

            }
            else if (guessAsInteger > magicNumberAsInteger)
            {
                Console.WriteLine("Lower");
            }
        }

        Console.WriteLine("You guessed it!");

    }
}