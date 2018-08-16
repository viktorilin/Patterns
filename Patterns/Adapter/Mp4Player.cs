using System;

namespace Patterns.Adapter
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayVlc(String fileName)
        {
        }
        public void PlayMp4(String fileName)
        {
            Console.WriteLine("Playing mp4 file. Name: " + fileName);
        }
    }
}