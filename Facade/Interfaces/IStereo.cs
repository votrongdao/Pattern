// File: IStereo.cs
// Coder: Sergiy Lischuk
// Created: 03:10:2013  15:50
// Email: evertodante@gmail.com

namespace Facade.Interfaces
{
    public interface IStereo
    {
        void On();
        void Off();
        void SetVolume(int volume);
    }
}