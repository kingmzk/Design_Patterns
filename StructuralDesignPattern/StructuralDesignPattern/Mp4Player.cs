using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class Mp4Player
    {
       public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing MP4 file: " + fileName);
        }
    }
}
