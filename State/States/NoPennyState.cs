#region

// File: SoldState.cs
// Coder: Sergiy Lischuk
// Created: 09:10:2013  20:58
// Email: evertodante@gmail.com

using RunPattern;
using State.Interfaces;

#endregion

namespace State.States
{
    /// <summary>
    /// This state represent as position in whitch we dont puts penny
    /// </summary>
    public class NoPennyState : IState
    {
        private readonly GumMachine _gumMachine;
        private readonly IOutputWritter _writter;

        public NoPennyState(GumMachine gumMachine, IOutputWritter writter)
        {
            _gumMachine = gumMachine;
            _writter = writter;
        }


        public void InsertPenny()
        {
            _writter.WriteLine("Insterted Penny. Lets Play!");
            _gumMachine.SetState(_gumMachine.HasPenny);
        }

        public void EjectPenny()
        {
            _writter.WriteLine("For start playing need money!");
        }

        public void TurnCrank()
        {
            _writter.WriteLine("No reaction. Need money for start");
        }

        public void Dispence()
        {
            _writter.WriteLine("No dispence. Pay frist");
        }
    }
}