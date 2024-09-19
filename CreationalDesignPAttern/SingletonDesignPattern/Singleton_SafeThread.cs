using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class Singleton_SafeThread
    {
        public static Singleton_SafeThread _instance;

        public static readonly Object _lock = new Object(); // Lock object for thread-safety


        private Singleton_SafeThread()
        {
            Console.WriteLine("Singleton Instance Created");
        }

        public static Singleton_SafeThread GetInstance()
        {
            // Lock the code to prevent multiple threads from creating new instances at the same time

            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton_SafeThread();
                }
            }

            return _instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Singleton instance method called.");
        }
    }
}
