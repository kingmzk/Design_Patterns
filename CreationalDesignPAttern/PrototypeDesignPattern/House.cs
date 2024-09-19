using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class House : IPrototype
    {
        public int Walls { get; set; }

        public int Doors { get; set; }

        public bool HasGarage { get; set; }

        public BluePrint HouseBluePrint { get; set; }

        public House(int walls, int doors, bool hasGarage, BluePrint houseBluePrint)
        {
            this.Walls = walls;
            this.Doors = doors;
            this.HasGarage = hasGarage;
            this.HouseBluePrint = houseBluePrint;
        }

        // Implementing the Clone method for shallow copy
        public IPrototype Clone()
        {
            // Shallow copy: Only copies values, not objects inside objects
           //  return (IPrototype)this.MemberwiseClone();

            return new House(this.Walls, this.Doors, this.HasGarage, this.HouseBluePrint.DeepCopy());
        }

        public override string ToString()
        {
            //return $"House with {Walls} walls, {Doors} doors, and {(HasGarage ? "a" : "no")} garage.";
            return $"House with {Walls} walls, {Doors} doors, and {(HasGarage ? "a" : "no")} garage.\n{HouseBluePrint}";
        }
    }
}
