// File: IState.cs
// Coder: Sergiy Lischuk
// Created: 09:10:2013  20:56
// Email: evertodante@gmail.com

namespace State.Interfaces
{
    /// <summary>
    /// Our this is a father of our states
    /// </summary>
    public interface IState
    {
        void InsertPenny();
        void EjectPenny();
        void TurnCrank();
        void Dispence();
    }
}