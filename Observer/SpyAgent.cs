using System;
using Observer.Interfaces;

namespace Observer
{
    public abstract class SpyAgent:IObserver
    {
        private string _operation;
        private string _status;

        public string Name;

        protected SpyAgent(string name)
        {
            Name = name;
        }

        public void UpdateInformation(string status, string operation)
        {
            _operation = operation;
            _status = status;
        }

        public void Confirm()
        {
            Console.WriteLine("I understand. Agent {0} take mission {1} with status {2}",Name,_operation, _status);
        }
    }
}
