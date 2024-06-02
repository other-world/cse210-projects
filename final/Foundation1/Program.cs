using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Puppy Tricks", "Jamie Cummings", 90);
        Comment video1comment1 = new Comment("CliffC", "Looks like they're working hard.");
        Comment video1comment2 = new Comment("GrantC", "It's hard to teach an old dog new tricks, but Mari knows her tricks and does them well.");
        Comment video1comment3 = new Comment("bot1", "Nice video, check out my website: http://definitelynotascam.com/");
        video1.AddComment(video1comment1);
        video1.AddComment(video1comment2);
        video1.AddComment(video1comment3);

        Video video2 = new Video("Don't Pick, Plant", "Jamie Cummings", 270);
        Comment video2comment1 = new Comment("GirlOnAHike", "I had no idea I could buy native plants for my yard. Thank you!");
        Comment video2comment2 = new Comment("DontTreadOnMe4982", "Sounds like more overregulation of public spaces.");
        Comment video2comment3 = new Comment("MountainMan3278", "Totally agree. if you pick plants they'll just die before you get home. People are ruining nature.");
        video2.AddComment(video2comment1);
        video2.AddComment(video2comment2);
        video2.AddComment(video2comment3);

        Video video3 = new Video("Greening the Desert", "Geoff Lawton", 1890);
        Comment video3comment1 = new Comment("bbeacher", "Just signed up for your next course!");
        Comment video3comment2 = new Comment("MattPowers", "Great work from the Prince of Permaculture");
        Comment video3comment3 = new Comment("SofieTheGreenThumb", "I wonder what practices need to be adjusted to work with a high altitude desert...");
        Comment video3comment4 = new Comment("Sepp Holtzer", "The torch has been passed.");
        video3.AddComment(video3comment1);
        video3.AddComment(video3comment2);
        video3.AddComment(video3comment3);
        video3.AddComment(video3comment4);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.GetVideoInfo();
            Console.WriteLine();
        }
    }
}