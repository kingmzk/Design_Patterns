using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Step 3: Create the Adapter
//The adapter implements the IMediaPlayer interface and internally uses the incompatible Mp4Player and VlcPlayer classes to make them compatible with the client's expected interface.


namespace AdapterDesignPattern
{
    public class MediaAdapter : IMediaPlayer
    {
        private Mp4Player _mp4Player;
        private VlcPlayer _vlcPlayer;

        public MediaAdapter(string audioType)
        {
            if(audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                _mp4Player = new Mp4Player();
            }
            else if(audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                _vlcPlayer = new VlcPlayer();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                _mp4Player.PlayMp4(fileName);
            }

            else if(audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                _vlcPlayer.PlayVlc(fileName);
            }
        }
    }
}
