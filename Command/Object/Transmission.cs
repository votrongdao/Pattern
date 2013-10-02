// File: Transmission.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  17:13
// Email: evertodante@gmail.com

using System;

namespace Command.Object
{
    public enum TransmissonStatus
    {
        Auto,
        Semi,
        Manual
    }

    /// <summary>
    /// This is model of James Bond cars transmission. By default its have status auto
    /// </summary>
    public class Transmission
    {
        public TransmissonStatus Status { get; set; }

        public Transmission()
        {
            Status = TransmissonStatus.Auto;
        }

        public override string ToString()
        {
            return String.Format("Transmission status: {0}\n", Status);
        }
    }
}