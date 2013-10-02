// File: ConsoleWritter.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  20:16
// Email: evertodante@gmail.com

#region

using System;

#endregion

namespace RunPattern
{
    public class ConsoleWritter : IOutputWritter
    {
        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }

        public void WriteLine(string output, object[] parameter)
        {
            Console.WriteLine(output, parameter);
        }
    }
}