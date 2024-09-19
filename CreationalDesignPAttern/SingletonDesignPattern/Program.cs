namespace SingletonDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Singleton singleton1 = Singleton.GetInstance();
            singleton1.ShowMessage(); // Output: Singleton instance method called.


            Singleton singleton2 = Singleton.GetInstance();
            singleton2.ShowMessage(); // Output: Singleton instance method called.

            if(singleton1 == singleton2)
            {
                Console.WriteLine("Both references point to the same instance.");
            }
            */

            Singleton_SafeThread singleton_SafeThread = Singleton_SafeThread.GetInstance();
            singleton_SafeThread.ShowMessage();

            Singleton_SafeThread singleton_SafeThread2 = Singleton_SafeThread.GetInstance();
            singleton_SafeThread2.ShowMessage();

            if(singleton_SafeThread == singleton_SafeThread2)
            {
                Console.WriteLine("Both references point to the same instance.");
            }
        }
    }
}   