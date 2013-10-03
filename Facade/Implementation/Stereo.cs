// File: Stereo.cs
// Coder: Sergiy Lischuk
// Created: 03:10:2013  15:48
// Email: evertodante@gmail.com

#region

using System;
using Facade.Interfaces;
using RunPattern;

#endregion

namespace Facade.Implementation
{
    /// <summary>
    /// This is realization of stereo in car
    /// </summary>
    public class Stereo : IStereo
    {
        public bool Active { get; set; }
        public int Volume { get; set; }
        private readonly IOutputWritter _writter;

        public Stereo(IOutputWritter writter)
        {
            _writter = writter;
            Active = false;
            Volume = 0;
        }

        public override string ToString()
        {
            return String.Format("Stereo status: {0}\n Stereo volume {1}\n", Active, Volume);
        }

        public void On()
        {
            Active = true;
            SetVolume(0);
            _writter.WriteLine("Radio on");
        }

        public void Off()
        {
            Active = false;
            SetVolume(0);
            _writter.WriteLine("Radio Off");
        }

        public void SetVolume(int volume)
        {
            Volume = volume;
            _writter.WriteLine( String.Format("Volume - {0}",volume));
        }
    }
}