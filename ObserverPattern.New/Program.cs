using ObserverPattern.New.Notifier;
using System;

namespace ObserverPattern.New
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoData = new VideoData();

            var emailNotifier = new EmailNotifier(videoData);
            var phoneNotifier = new PhoneNotifier(videoData);
            var youtubeNotifier = new YoutubeNotifier(videoData);

            videoData.SetTitle("Observer Design Pattern");

            videoData.DetachObserver(youtubeNotifier);

            Console.WriteLine("------------------------------");
            videoData.SetDescription("Duy's video");

            _ = new FacebookNotifier(videoData);
            Console.WriteLine("------------------------------");
            videoData.SetFileName("A very good tutorial");
        }
    }
}
