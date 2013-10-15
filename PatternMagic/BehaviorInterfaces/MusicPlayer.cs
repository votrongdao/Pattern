// File: MusicPlayer.cs
// Coder: Sergiy Lischuk
// Created: 15.10.2013  17:18
// Email: evertodante@gmail.com

namespace PatternMagic.BehaviorInterfaces
{
    public interface IMusicPlayer
    {
        string NowPlaying();
        void Next();
        void Prev();
        void Pause();
        void Stop();
    }
}