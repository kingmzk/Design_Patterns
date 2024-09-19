using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class WindowsButton : IButton
    {
        public void render()
        {
            Console.WriteLine("Rendering Windows Button");
        }
    }
}
