using System;

namespace Patterns.Adapter
{
    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter mediaAdapter;
        public void Play(String audioType, String fileName)
        {
            //Вбудована підтримка для відтворення mp3-музичних файлів
            if (audioType.Equals("mp3", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Playing mp3 file. Name: " + fileName);
            }
            //MediaAdapter підтримує відтворення інших форматів файлів
            else if (audioType.Equals("vlc", StringComparison.InvariantCultureIgnoreCase) || audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported");
            }
        }
    }
}