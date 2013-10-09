#region

// File: SoldOutState.cs
// Coder: Sergiy Lischuk
// Created: 09:10:2013  21:12
// Email: evertodante@gmail.com

using RunPattern;
using State.Interfaces;

#endregion

namespace State.States
{
    /// <summary>
    /// This case is for sold out state
    /// </summary>
    public class SoldOutState : IState
    {
        private readonly GumMachine _machine;
        private readonly IOutputWritter _writter;

        public SoldOutState(GumMachine machine, IOutputWritter writter)
        {
            _machine = machine;
            _writter = writter;
        }

        public void InsertPenny()
        {
            _writter.WriteLine("Gums are sold out!");
            //_machine.SetState(_machine.SoldOut);//todo think about it
        }

        public void EjectPenny()
        {
            _writter.WriteLine("You cant got back you penny. Sold out");
           // _machine.SetState(_machine.NoPenny);
        }

        public void TurnCrank()
        {
            _writter.WriteLine("Cant Turn! Sold out");
        }

        public void Dispence()
        {
            _writter.WriteLine("There are no gumballs. Sold Out");
        }
    }
}