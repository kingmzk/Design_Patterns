using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class VlcPlayer
    {
        public void PlayVlc(string filename)
        {
            Console.WriteLine("Playing VLC file " + filename);
        }
    }
}
