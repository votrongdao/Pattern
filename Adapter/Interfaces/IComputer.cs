// File: IComputer.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  20:00
// Email: evertodante@gmail.com

namespace Adapter.Interfaces
{
    /// <summary>
    /// One of 2 object wich will be take part in our experiment
    /// </summary>
    internal interface IComputer
    {
        void Hello();
        void RunBrowser();
        void SwitchOff();
    }
}