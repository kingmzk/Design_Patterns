using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class HouseFactory
    {
        public IHouse CreateHouse(string houseType)
        {
            switch (houseType.ToLower())
            {
                case "villa":
                    return new Villa();
                case "apartment":
                    return new Apartment();
                case "cottage":
                    return new Cottage();
                default:
                    throw new ArgumentException("Invalid house type");
            }
        }
    }
}
