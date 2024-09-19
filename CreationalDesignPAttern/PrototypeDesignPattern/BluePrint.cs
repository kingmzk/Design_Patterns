using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class BluePrint
    {
        public string Design {  get; set; }

        public BluePrint(string design)
        {
            this.Design = design;
        }

        // Implement a deep copy for Blueprint
        public BluePrint DeepCopy()
        {
            return new BluePrint(this.Design);
        }

        public override string ToString()
        {
            return $"Blueprint: {Design}";
        }
    }
}
