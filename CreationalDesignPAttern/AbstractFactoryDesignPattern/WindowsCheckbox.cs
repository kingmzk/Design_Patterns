using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class WindowsCheckbox : ICheckBox
    {
        public void Check()
        {
            Console.WriteLine("Checking Windows Checkbox");
        }
    }
}
