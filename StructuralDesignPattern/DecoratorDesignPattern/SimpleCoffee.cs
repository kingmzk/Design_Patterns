using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class SimpleCoffee : ICoffee
    {
        public double GetCost()
        {
            return 10.0;
        }

        public string GetDescription()
        {
            return "Simple Coffee";
        }
    }
}
