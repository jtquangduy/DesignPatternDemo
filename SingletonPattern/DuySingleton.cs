using System;

namespace SingletonPattern
{
    public class DuySingleton
    {
        private int index;
        private static readonly object lockObject = new object();
        private static volatile DuySingleton uniqueInstance;

        private DuySingleton(int index)
        {
            this.index = index;
        }

        public static DuySingleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (lockObject)
                {
                    if (uniqueInstance == null)
                    {
                        var random = new Random();
                        uniqueInstance = new DuySingleton(random.Next(1, 4));
                    }
                }
            }
            return uniqueInstance;
        }

        public void SaysHi()
        {
            Console.WriteLine("Hello every, I am Duy namber" + index);
        }
    }
}