namespace AbstractFactoryDesignPattern
{
    class Programe
    {
        public static void Main(string[] args)
        {
            //  Example 1: Using Windows Factory
            IGUIFactory windowsFactory = new WindowsFactory();
            Application windowsApp = new Application(windowsFactory);
            windowsApp.Run();  // Output: Rendering Windows Button, Checking Windows Checkbox


            IGUIFactory macFactory = new MacFactory();
            Application macApp = new Application(macFactory);
            macApp.Run();  // Output: Rendering Mac Button, Checking Mac Checkbox
        }
    }
}