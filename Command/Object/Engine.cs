// File: Engine.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  17:12
// Email: evertodante@gmail.com

using System;

namespace Command.Object
{
    /// <summary>
    /// Its a heart of jame`s car
    /// </summary>
    public class Engine
    {
        public bool Active { get; set; }
        public override string ToString()
        {
            return String.Format("Engine Status: {0} \n", Active);
        }
    }
}