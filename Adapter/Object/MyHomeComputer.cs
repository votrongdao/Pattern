// File: MyHomeComputer.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  20:04
// Email: evertodante@gmail.com

#region

using Adapter.Interfaces;
using RunPattern;

#endregion

namespace Adapter.Object
{
    /// <summary>
    /// Realization of IComputer <see cref="IComputer"/>
    /// </summary>
    public class MyHomeComputer : IComputer
    {
        private readonly IOutputWritter _writter;

        public MyHomeComputer(IOutputWritter writtter)
        {
            _writter = writtter;
        }

        public void Hello()
        {
            _writter.WriteLine("Hi from computer");
        }

        public void RunBrowser()
        {
            _writter.WriteLine("Search google.com from Mozilla ");
        }

        public void SwitchOff()
        {
            _writter.WriteLine("Param-pa-pa Bye! PC off");
        }
    }
}