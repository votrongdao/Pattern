#region

// File: HasPennyState.cs
// Coder: Sergiy Lischuk
// Created: 09:10:2013  21:17
// Email: evertodante@gmail.com

using RunPattern;
using State.Interfaces;

#endregion

namespace State.States
{
    /// <summary>
    /// State when penny inside
    /// </summary>
    public class HasPennyState : IState
    {
        private readonly IOutputWritter _writter;
        private readonly GumMachine _gumMachine;

        public HasPennyState(IOutputWritter writter, GumMachine gumMachine)
        {
            _writter = writter;
            _gumMachine = gumMachine;
        }

        public void InsertPenny()
        {
            _writter.WriteLine("You inserted penny before. Lets Play");
        }

        public void EjectPenny()
        {
            _writter.WriteLine("Output penny");
            _gumMachine.SetState(_gumMachine.NoPenny);
        }

        public void TurnCrank()
        {
            _writter.WriteLine("Running...");
            _gumMachine.SetState(_gumMachine.Sold);
        }

        public void Dispence()
        {
            _writter.WriteLine("No gums out");
        }
    }
}