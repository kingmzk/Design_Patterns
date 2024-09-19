using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Step 3: Create the Abstract Factory Interface

namespace AbstractFactoryDesignPattern
{
    public interface IGUIFactory
    {
        IButton CreateButton();

        ICheckBox CreateCheckbox();
    }
}
