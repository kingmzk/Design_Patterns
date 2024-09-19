using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3. Concrete Builder: Implements the builder interface.

namespace BuilderPattern
{
    public class HouseBuilder : IHouseBuilder
    {
        private House _house = new House();


        public IHouseBuilder BuildDoors(int count)
        {
            _house.Doors = count;
            return this;
        }

        public IHouseBuilder BuildWalls(int count)
        {
            _house.Walls = count;
            return this;
        }

        public IHouseBuilder BuildWindows(int count)
        {
            _house.Windows = count;
            return this;
        }

        public IHouseBuilder hasGarage(bool hasGarage)
        {
            _house.hasGarage = hasGarage;
            return this;
        }

        public House Build()
        {
            return _house;
        }
    }
}
