// File: Engine.cs
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
    /// Its a heart of jame`s car
    /// </summary>
    public class Engine : IEngine
    {
        public bool Active { get; set; }
        private readonly IOutputWritter _writter;


        public Engine(IOutputWritter writter)
        {
            Active = false;
            _writter = writter;
        }


        public override string ToString()
        {
            return String.Format("Engine Status: {0} \n", Active);
        }

        public void Start()
        {
            if (!Active)
            {
                Active = true;
            }
            _writter.WriteLine("Endgine starting");
        }

        public void Stop()
        {
            if (Active)
            {
                Active = false;
            }
            _writter.WriteLine("Engine stops");
        }
    }
}