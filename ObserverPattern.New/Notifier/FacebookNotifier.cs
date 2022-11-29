using ObserverPattern.New.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.New.Notifier
{
    public class FacebookNotifier : Observer
    {
        public FacebookNotifier(Subject subject)
        {
            Subject = subject;
            Subject.AttachObserver(this);
        }

        public override void Notify(Subject subject, object arg)
        {
            if (subject is VideoData videoData)
            {
                Console.WriteLine(string.Format($"Notify all subcribers via FACEBOOK with new data" +
                                                    "\n\tName:{0}" +
                                                    "\n\tDescription:{1}" +
                                                    "\n\tFile Name:{2}",
                                                    videoData.GetTitle(), videoData.GetDescription(), videoData.GetFileName()));
            }
        }
    }
}