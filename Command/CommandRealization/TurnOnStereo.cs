// File: TurnOnStereo.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  17:25
// Email: evertodante@gmail.com

#region

using System;
using Command.Interfaces;
using Command.Object;

#endregion

namespace Command.CommandRealization
{
    /// <summary>
    /// Now we just realize some command with which we can working
    /// </summary>
    public class TurnOnStereo : ICommand
    {
        private readonly Stereo _stereo;

        public TurnOnStereo(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            if (_stereo.Active == false)
            {
                _stereo.Active = true;
            }
            Console.WriteLine("Stereo status: Active");
        }
    }
}