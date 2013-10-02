// File: SetFavoriteVolume.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  17:30
// Email: evertodante@gmail.com

#region

using System;
using Command.Interfaces;
using Command.Object;

#endregion

namespace Command.CommandRealization
{
    /// <summary>
    /// <see cref="TurnOnStereo"/>
    /// </summary>
    public class SetFavoriteVolume : ICommand
    {
        private readonly Stereo _stereo;

        public SetFavoriteVolume(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.Volume = 5;
            Console.WriteLine("Radio Fm set volume to 5");
        }
    }
}