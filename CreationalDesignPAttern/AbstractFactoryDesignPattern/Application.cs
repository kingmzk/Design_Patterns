using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public  class Application
    {
        private readonly IButton _button;
        private readonly ICheckBox _checkbox;

        public Application(IGUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();

        }

        public void Run()
        {
            _button.render();
            _checkbox.Check();
        }
    }
}
