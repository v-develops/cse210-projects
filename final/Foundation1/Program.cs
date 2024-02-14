using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();


        // Video Number One //
        Video video1 = new Video("How to start making pixel art - for begginers", "TonyRetro", 475);

        Comments video1Comment1 = new Comments("Emilia734", "Just what I was looking for!");
        video1.AddComment(video1Comment1);

        Comments video1Comment2 = new Comments("Fried_stone19", "This video helped me to improve my art by a lot, and in just few days.");
        video1.AddComment(video1Comment2);

        Comments video1Comment3 = new Comments("dokomei1240", "Is there any other free software that I could use?");
        video1.AddComment(video1Comment3);

        Comments video1Comment4 = new Comments("ST0N3", "Straight to the main point. Love this video.");
        video1.AddComment(video1Comment4);

        videosList.Add(video1);


        // Video Number Two //
        Video video2 = new Video("Track 1: Magical Astronomy - Welcome to the Moon Tour", "ZUN", 272);

        Comments video2Comment1 = new Comments("zizzwinghi", "A beautiful opener to this magical album.");
        video2.AddComment(video2Comment1);

        Comments video2Comment2 = new Comments("jackestripador01", "I found another one but this one have higher sound. Ty, downloading music from here xD");
        video2.AddComment(video2Comment2);

        Comments video2Comment3 = new Comments("CullixUshiromiya", "This theme would be a perfect stage theme.");
        video2.AddComment(video2Comment3);

        Comments video2Comment4 = new Comments("SHinierthennyourforehead", "WATCH OUT RENKO, YOU'RE GONNA FALL DOWN!");
        video2.AddComment(video2Comment4);

        videosList.Add(video2);


        // Video Number Three //
        Video video3 = new Video("How to convert .MP3 audio to .OGG", "FLExpert007", 976);

        Comments video3Comment1 = new Comments("BeatJonny81733", "Amazing tutorial...");
        video3.AddComment(video3Comment1);

        Comments video3Comment2 = new Comments("HelloKiwi", "Its not working for me :(");
        video3.AddComment(video3Comment2);

        Comments video3Comment3 = new Comments("Amunanosgsg5", "Thank you very much! I was trying to do this for hours!");
        video3.AddComment(video3Comment3);

        Comments video3Comment4 = new Comments("Pepino", "I already knew how to do this.");
        video3.AddComment(video3Comment4);

        videosList.Add(video3);


        // Display all Videos //
        Console.Clear();

        foreach (Video video in videosList)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            video.VideoInfo();
        }

        Console.WriteLine("-----------------------------------------------------------------------------------------");
        Console.WriteLine();
    }
}