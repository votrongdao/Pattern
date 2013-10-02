// File: SetTransmittionToAutoMode.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  17:43
// Email: evertodante@gmail.com

#region

using System;
using Command.Interfaces;
using Command.Object;

#endregion

namespace Command.CommandRealization
{
    /// <summary>
    /// This command set status of transmission to auto
    /// </summary>
    public class SetTransmittionToAutoMode : ICommand
    {
        private readonly Transmission _transmission;

        public SetTransmittionToAutoMode(Transmission transmission)
        {
            _transmission = transmission;
        }

        public void Execute()
        {
            _transmission.Status = TransmissonStatus.Auto;
            Console.WriteLine("Transsmision status: {0}", _transmission.Status);
        }
    }
}