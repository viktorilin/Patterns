using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public interface IMediaPlayer
    {
     void Play(String audioType, String fileName);
    }
}
