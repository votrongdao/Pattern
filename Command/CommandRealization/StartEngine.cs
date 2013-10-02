// File: StartEngine.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  17:33
// Email: evertodante@gmail.com

#region

using System;
using Command.Interfaces;
using Command.Object;

#endregion

namespace Command.CommandRealization
{
    /// <summary>
    /// Command to start car`s engine
    /// </summary>
    public class StartEngine : ICommand
    {
        private readonly Engine _engine;

        public StartEngine(Engine engine)
        {
            _engine = engine;
        }

        public void Execute()
        {
            if (!_engine.Active)
            {
                _engine.Active = true;
            }
            Console.WriteLine("Engine status: Active");
        }
    }
}