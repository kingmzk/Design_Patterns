namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //simple coffee
            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine(coffee.GetDescription() + " $ "+ coffee.GetCost());

            //coffee with Milk
            coffee = new MilkDecorator(coffee);
            Console.WriteLine(coffee.GetDescription() + " $ "+ coffee.GetCost());

            //coffee with milk and sugar
            coffee = new SugarDecorator(coffee);
            Console.WriteLine(coffee.GetDescription() + " $ " + coffee.GetCost());
        }
    }
}