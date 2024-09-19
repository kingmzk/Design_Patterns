using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. Product: The object that will be constructed.

namespace BuilderPattern
{
    public class House
    {
        public int Walls { get; set; }

        public int Doors { get; set; }

        public int Windows { get; set; }

        public bool hasGarage { get; set; }

        public override string ToString()
        {
            return $"House with {Walls} walls , {Doors} doors , {Windows} windows , {hasGarage} garage";
        }

    }
}
