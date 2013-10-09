#region

// File: RunState.cs
// Coder: Sergiy Lischuk
// Created: 08:10:2013  21:55
// Email: evertodante@gmail.com

using RunPattern;

#endregion

namespace State
{
    public class RunState : Run
    {
        public override void RunApp()
        {
           IOutputWritter writter = new ConsoleWritter();
            var machine = new GumMachine(10, writter);

            machine.InsertPenny();
            machine.Turn();
            
            writter.WriteLine("\n");
            machine.InsertPenny();
            machine.EjectPenny();
            machine.EjectPenny();

            writter.WriteLine("\n");
            machine = new GumMachine(0, writter);
            machine.Turn();
            machine.InsertPenny();
        }
    }
}