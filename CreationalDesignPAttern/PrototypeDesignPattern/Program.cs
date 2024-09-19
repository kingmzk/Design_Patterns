namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Create a prototype object
            House originalHouse = new House(10, 20, true);
            Console.WriteLine("Original" + originalHouse.ToString());

            // Clone the prototype object
            House clonedHouse = (House)originalHouse.Clone();
            Console.WriteLine("Cloned" + clonedHouse.ToString());


            //Modify Cloned Object
            clonedHouse.Doors = 50;
            Console.WriteLine("Modified Cloned" + clonedHouse.ToString());


            // Show the original is still unchanged
            Console.WriteLine("Original after clone modification: " + originalHouse.ToString());
            */





            BluePrint originalBlueprint = new BluePrint("Modern Design");
            House originalHouse = new House(10, 5, true, originalBlueprint);

            Console.WriteLine("Original House:");
            Console.WriteLine(originalHouse.ToString());

            // Clone the house object (deep copy)
            House clonedHouse = (House)originalHouse.Clone();

            Console.WriteLine("\nCloned House:");
            Console.WriteLine(clonedHouse.ToString());

            // Modify the blueprint in the cloned house
            clonedHouse.HouseBluePrint.Design = "Colonial Design";

            Console.WriteLine("\nModified Cloned House Blueprint:");
            Console.WriteLine(clonedHouse.ToString());

            // Check that the original house blueprint remains unchanged
            Console.WriteLine("\nOriginal House after modification in the cloned house:");
            Console.WriteLine(originalHouse.ToString());
        }
    }
}