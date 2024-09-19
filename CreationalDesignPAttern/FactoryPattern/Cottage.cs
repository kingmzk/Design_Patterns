using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Cottage : IHouse
    {
        public void ShowDetails()
        {
            Console.WriteLine("This is a cozy cottage with 2 bedrooms and a fireplace.");
        }
    }
}
