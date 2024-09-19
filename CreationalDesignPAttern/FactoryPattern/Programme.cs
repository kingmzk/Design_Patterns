using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Programme
    {
        public static void Main(string[] args)
        {
            HouseFactory houseFactory = new HouseFactory();

            IHouse villa = houseFactory.CreateHouse("villa");
            villa.ShowDetails();

            IHouse apartment = houseFactory.CreateHouse("apartment");
            apartment.ShowDetails();

            IHouse cottage = houseFactory.CreateHouse("cottage");
            cottage.ShowDetails();
           
        }
    }
}
