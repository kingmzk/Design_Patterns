using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Apartment : IHouse
    {
        public void ShowDetails()
        {
            Console.WriteLine("This is a modern apartment with 3 bedrooms and a balcony.");
        }
    }
}
