// File: ICommand.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  17:05
// Email: evertodante@gmail.com

namespace Command.Interfaces
{
    /// <summary>
    /// All our command will be inerhit this interface
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// In our case will be better return some value - status of  command
        /// </summary>
        void Execute();
    }
}