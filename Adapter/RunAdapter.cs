// File: RunAdapter.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  20:18
// Email: evertodante@gmail.com

#region

using Adapter.Interfaces;
using Adapter.Object;
using RunPattern;

#endregion

namespace Adapter
{
    public class RunAdapter : Run
    {
        public override void RunApp()
        {
            IOutputWritter writter = new ConsoleWritter();
            ISmartPhone phone = new MySmartPhone(writter);
            IComputer computer = new MyHomeComputer(writter);

            phone.SwitchOn();
            phone.GoToInternet();
            phone.SwitchOff();

            computer.Hello();
            computer.RunBrowser();
            computer.SwitchOff();

            //now fun
            phone = new ComputerToPhoneAdapter((MyHomeComputer) computer);
            phone.SwitchOn();
            phone.GoToInternet();
            phone.SwitchOff();
        }
    }
}