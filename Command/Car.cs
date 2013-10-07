// File: Car.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  17:49
// Email: evertodante@gmail.com

#region

using Command.Object;

#endregion

namespace Command
{
    /// <summary>
    /// Dont forget what we controls a car
    /// </summary>
    public class Car
    {
        public Stereo Stereo { get; set; }
        public Engine Engine { get; set; }
        public RocketBarrage RocketBarrage { get; set; }
        public Transmission Transmission { get; set; }

        /// <summary>
        /// Only for example. Its bad idea - we need constructor with such parameter
        /// </summary>
        public Car()
        {
            Stereo = new Stereo();
            Engine = new Engine();
            Transmission = new Transmission();
            RocketBarrage = new RocketBarrage();
        }

        /// <summary>
        /// Returned Current status of all cars parts
        /// </summary>
        /// <returns>Status of Part</returns>
        public override string ToString()
        {
            return "Car status::\n"+ Engine.ToString() + Stereo.ToString() + Transmission.ToString() + RocketBarrage.ToString();
        }
    }
}