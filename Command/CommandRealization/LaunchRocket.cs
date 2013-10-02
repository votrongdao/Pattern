// File: LaunchRocket.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  17:36
// Email: evertodante@gmail.com

#region

using System;
using Command.Interfaces;
using Command.Object;

#endregion

namespace Command.CommandRealization
{
    /// <summary>
    /// Smash them!
    /// </summary>
    public class LaunchRocket : ICommand
    {
        private readonly RocketBarrage _rocket;

        public LaunchRocket(RocketBarrage rocket)
        {
            _rocket = rocket ?? new RocketBarrage();
        }

        /// <summary>
        /// In a real life we send parameter for a funciton and then use it. 
        /// In this case example with rocket barrage very bad and thats why we 
        /// must belive what all correct
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("Lunch Rocket. Target {0} Count {1}", _rocket.Target, _rocket.Count);
            _rocket.SetAndLaunch("Enemy", 10);
        }

    }
}