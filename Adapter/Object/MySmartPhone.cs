// File: MySmartPhone.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  20:52
// Email: evertodante@gmail.com

#region

using Adapter.Interfaces;
using RunPattern;

#endregion

namespace Adapter.Object
{
    /// <summary>
    /// Realization of ISmartPhone <see cref="ISmartPhone"/>
    /// </summary>
    public class MySmartPhone : ISmartPhone
    {
        private readonly IOutputWritter _writter;

        public MySmartPhone(IOutputWritter writter)
        {
            _writter = writter;
        }

        public void SwitchOn()
        {
            _writter.WriteLine("Android run");
        }

        public void GoToInternet()
        {
            _writter.WriteLine("Mobile opera for android - www.google.com");
        }

        public void SwitchOff()
        {
            _writter.WriteLine("Phone off");
        }
    }
}