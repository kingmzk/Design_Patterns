using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Villa : IHouse
    {
        public void ShowDetails()
        {
            Console.WriteLine("This is a luxurious villa with 5 bedrooms, a pool, and a garden.");
        }
    }
}
