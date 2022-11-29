﻿using ObserverPattern.New.Base;
using System;

namespace ObserverPattern.New.Notifier
{
    public class PhoneNotifier : Observer
    {
        public PhoneNotifier(Subject subject)
        {
            Subject = subject;
            Subject.AttachObserver(this);
        }

        //public void Notify(string name, string description, string fileName)
        //{
        //    Console.WriteLine(string.Format($"Notify all subcribers via PHONE NUMBER with new data" +
        //                                        "\n\tName:{0}" +
        //                                        "\n\tDescription:{1}" +
        //                                        "\n\tFile Name:{2}",
        //                                        name, description, fileName));
        //}

        public override void Notify(Subject subject, object arg)
        {
            if (subject is VideoData videoData)
            {
                Console.WriteLine(string.Format($"Notify all subcribers via PHONE NUMBER with new data" +
                                                    "\n\tName:{0}" +
                                                    "\n\tDescription:{1}" +
                                                    "\n\tFile Name:{2}",
                                                    videoData.GetTitle(), videoData.GetDescription(), videoData.GetFileName()));
            }
        }
    }
}