#region

// File: SoldState.cs
// Coder: Sergiy Lischuk
// Created: 09:10:2013  21:35
// Email: evertodante@gmail.com

using RunPattern;
using State.Interfaces;

#endregion

namespace State.States
{
    /// <summary>
    /// State for winning gum
    /// </summary>
    internal class SoldState : IState
    {
        private readonly GumMachine _machine;
        private readonly IOutputWritter _writter;

        public SoldState(GumMachine machine, IOutputWritter writter)
        {
            _machine = machine;
            _writter = writter;
        }

        public void InsertPenny()
        {
            _writter.WriteLine("Plese wait. Gum is loading");
        }

        public void EjectPenny()
        {
            _writter.WriteLine("Crank was turned");
        }

        public void TurnCrank()
        {
            _writter.WriteLine("You can use it twice");
        }

        public void Dispence()
        {
            _machine.ReleseBall();
            if (_machine.GetCount() > 0)
            {
                _machine.SetState(_machine.NoPenny);
            }
            else
            {
                _writter.WriteLine("Sorry, gums are lost");
                _machine.SetState(_machine.SoldOut);
            }
        }
    }
}