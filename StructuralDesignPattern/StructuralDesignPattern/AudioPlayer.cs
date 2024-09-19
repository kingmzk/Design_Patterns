using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Step 4: Implement the Concrete Client
//Now, we create a media player that can use the adapter to play different formats.

namespace AdapterDesignPattern
{
    public class AudioPlayer : IMediaPlayer
    {

        private MediaAdapter _mediaAdapter;

        public void Play(string audioType, string fileName)
        {
           if(audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
           {
                Console.WriteLine("Playing MP3 file: " + fileName);
           }
           else if(audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase) || audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
           {
                _mediaAdapter = new MediaAdapter(audioType);
                _mediaAdapter.Play(audioType, fileName);
           }
           else
           {
                Console.WriteLine("Invalid media type: " + audioType + " format not supported.");
           }
        }
    }
}
