using System;

namespace Patterns.Adapter
{
    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer advancedMusicPlayer;
        public MediaAdapter(String audioType)
        {
            if (audioType.Equals("vlc",StringComparison.InvariantCultureIgnoreCase))
            {
                advancedMusicPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }
    
        public void Play(String audioType, String fileName)
        {
            if (audioType.Equals("vlc", StringComparison.InvariantCultureIgnoreCase))
            {
                advancedMusicPlayer.PlayVlc(fileName);
            }
            else if (audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                advancedMusicPlayer.PlayMp4(fileName);
            }
        }
    }
}