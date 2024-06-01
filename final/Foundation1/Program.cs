using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Video video1 = new Video("Puppy Tricks", "Jamie Cummings", 90);
        Video video2 = new Video("Don't Pick, Plant", "Jamie Cummings", 270);
        Video video3 = new Video("Garden Tour", "Katie Moore", 300);
        Video video4 = new Video("Greening the Desert", "Geoff Lawton", 1890);

        Console.WriteLine(video1.NumOfComments());
    }
}