// File: Stereo.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  17:12
// Email: evertodante@gmail.com

using System;

namespace Command.Object
{
    /// <summary>
    /// This is realization of stereo in car
    /// </summary>
    public class Stereo
    {
        public bool Active { get; set; }
        public int Volume { get; set; }

        public Stereo()
        {
            Active = false;
            Volume = 0;
        }
        public override string ToString()
        {
            return String.Format("Stereo status: {0}\n Stereo volume {1}\n", Active, Volume);
        }
    }
}