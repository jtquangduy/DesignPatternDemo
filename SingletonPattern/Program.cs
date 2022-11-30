using System.Threading;

namespace SingletonPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var thread1 = new Thread(() => DuySingleton.GetInstance().SaysHi());
            var thread2 = new Thread(() => DuySingleton.GetInstance().SaysHi());

            thread1.Start();
            thread2.Start();
        }
    }
}