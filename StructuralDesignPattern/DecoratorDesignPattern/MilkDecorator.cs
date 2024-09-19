using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
            
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription()+" with milk";
        }

        public override double GetCost()
        {
            return _coffee.GetCost()+ 5.5;
        }
    }
}
