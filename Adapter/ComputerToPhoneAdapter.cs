// File: ComputerToPhoneAdapter.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  20:54
// Email: evertodante@gmail.com

#region

using Adapter.Interfaces;
using Adapter.Object;

#endregion

namespace Adapter
{
    /// <summary>
    /// Now computer works as telephone
    /// </summary>
    public class ComputerToPhoneAdapter : ISmartPhone
    {
        private readonly MyHomeComputer _copm;

        public ComputerToPhoneAdapter(MyHomeComputer copm)
        {
            _copm = copm;
        }

        public void SwitchOn()
        {
            _copm.Hello();
        }

        public void GoToInternet()
        {
            _copm.RunBrowser();
        }

        public void SwitchOff()
        {
            _copm.SwitchOff();
        }
    }
}