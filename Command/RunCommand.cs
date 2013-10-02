// File: RunCommand.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  17:46
// Email: evertodante@gmail.com

#region

using System;
using RunPattern;

#endregion

namespace Command
{
    public class RunCommand : Run
    {
        private JamesBondPhone _phone;
        private Car _car;

        public override void RunApp()
        {
            _car = new Car();
            _phone = new JamesBondPhone(_car);

            _phone.RunCommand(1);//active stereo
            Console.WriteLine(_car.ToString());
            Console.WriteLine("\n\n");

            _phone.RunCommand(3);//active engine
            _phone.RunCommand(4);//set transmission to auto type
            Console.WriteLine("\n\n");
            Console.WriteLine(_car.ToString());
            
        }
    }
}