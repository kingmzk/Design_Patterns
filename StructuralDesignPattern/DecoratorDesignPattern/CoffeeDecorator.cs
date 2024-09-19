﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        protected CoffeeDecorator(ICoffee coffee)
        {
            this._coffee = coffee; 
        }

        public virtual double GetCost()
        {
           return _coffee.GetCost();
        }

        public virtual string GetDescription()
        {
            return _coffee.GetDescription();
        }
    }
}
