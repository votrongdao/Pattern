// File: ISmartPhone.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  19:59
// Email: evertodante@gmail.com

namespace Adapter.Interfaces
{
    /// <summary>
    /// Second of 2 objects which will be take part in our experiment
    /// </summary>
    internal interface ISmartPhone
    {
        void SwitchOn();
        void GoToInternet();
        void SwitchOff();
    }
}