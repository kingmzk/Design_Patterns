namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer audioPlayer = new AudioPlayer();

            audioPlayer.Play("mp3","song.mp3");
            audioPlayer.Play("mp4", "viedo.mp4");
            audioPlayer.Play("vlc", "movie.vlc");
            audioPlayer.Play("avi", "movie.avi");
        }
    }
}