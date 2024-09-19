using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    internal class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + " with sugar";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 2.5;
        }
    }
}
