// File: GumMachine.cs
// Coder: Sergiy Lischuk
// Created: 09:10:2013  20:53
// Email: evertodante@gmail.com

using System;
using RunPattern;
using State.Interfaces;
using State.States;

namespace State
{
    public class GumMachine
    {
        public IState SoldOut { get; set; }
        public IState NoPenny { get; set; }
        public IState HasPenny { get; set; }
        public IState Sold { get; set; }
        private readonly IOutputWritter _writter;


        public IState CurrentState { get; private set; }
        private int _balls;

        public GumMachine(int balls, IOutputWritter writter)
        {
            _balls = balls;
            _writter = writter;
            SoldOut = new SoldOutState(this,_writter);
            NoPenny = new NoPennyState(this, _writter);
            Sold = new SoldState(this, _writter);
            HasPenny = new HasPennyState(_writter, this);
            CurrentState = _balls<=0 ? SoldOut : NoPenny;
            
        }

        public void InsertPenny()
        {
            CurrentState.InsertPenny();
        }

        public void EjectPenny()
        {
            CurrentState.EjectPenny();
        }


        public void Turn()
        {
            CurrentState.TurnCrank();
            CurrentState.Dispence();
        }

        public void SetState(IState state)
        {
            CurrentState = state;
        }

        public void ReleseBall()
        {
            _writter.WriteLine("You win. Recive you gum");
            if (_balls>0)
            {
                _balls--;
            }
        }

        public int GetCount()
        {
            return _balls;
        }
    }
}