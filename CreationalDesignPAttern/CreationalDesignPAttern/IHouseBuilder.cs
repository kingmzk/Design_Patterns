using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2. Builder Interface: Specifies how to build different parts of the product.

namespace BuilderPattern
{
    public interface IHouseBuilder
    {
        IHouseBuilder BuildWalls(int count);

        IHouseBuilder BuildDoors(int count);

        IHouseBuilder BuildWindows(int count);

        IHouseBuilder hasGarage(bool hasGarage);

        House Build();
    }
}
