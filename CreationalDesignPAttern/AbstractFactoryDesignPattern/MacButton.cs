using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class MacButton : IButton
    {
        public void render()
        {
            Console.WriteLine("Rendering Mac Button");
        }
    }
}
