using BuilderPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//4. Client Code: Demonstrates the use of the builder.

namespace CreationalDesignPAttern
{
    public class Programmed
    {
        public static void Main(string[] args)
        {
           HouseBuilder houseBuilder = new HouseBuilder();

            House house = houseBuilder.BuildWalls(10).BuildDoors(5).BuildWindows(3).hasGarage(true).Build();

            Console.WriteLine(house.ToString());
              
        }
    }
}
