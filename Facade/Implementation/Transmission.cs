// File: Transmission.cs
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
    public enum TransmissonStatus
    {
        Auto,
        Semi,
        Manual
    }

    public enum Gears
    {
        N,
        First,
        Second,
        Third,
        Four,
        R
    }

    /// <summary>
    /// This is model of James Bond cars transmission. By default its have status auto
    /// </summary>
    public class Transmission : ITransmission
    {
        public TransmissonStatus Status { get; private set; }

        /// <summary>
        /// dont forget about count 
        /// </summary>
        public Gears Gear { get; private set; }

        private readonly IOutputWritter _writter;

        public Transmission(IOutputWritter writter)
        {
            _writter = writter;
            Status = TransmissonStatus.Auto;
            Gear = Gears.N;
        }

        public override string ToString()
        {
            return String.Format("Transmission status: {0}\n", Status);
        }

        public void SetGear(Gears gear)
        {
            if (Status != TransmissonStatus.Manual)
            {
                _writter.WriteLine(String.Format("You Cant change you gear, becouse Transmission is {0}", Status));
                return;
            }
            Gear = gear;
            _writter.WriteLine(String.Format("Set gear - {0}", gear));
        }
    }
}