﻿using System;

namespace Patterns.Adapter
{
    public interface IAdvancedMediaPlayer
    {
        void PlayVlc(String fileName);
        void PlayMp4(String fileName);
    }
}