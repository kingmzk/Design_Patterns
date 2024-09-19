using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton() 
        {
            Console.WriteLine("Singleton Instance Created");
        }

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Singleton instance method called.");
        }
    }
}
