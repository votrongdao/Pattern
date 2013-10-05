using Observer.Interfaces;
using RunPattern;

namespace Observer
{
    public abstract class SpyAgent:IObserver
    {
        private string _operation;
        private string _status;

        public string Name;
        private readonly IOutputWritter _writter;
        protected SpyAgent(string name, IOutputWritter writter)
        {
            Name = name;
            _writter = writter;
        }

        public void UpdateInformation(string status, string operation)
        {
            _operation = operation;
            _status = status;
        }

        public void Confirm()
        {
            _writter.WriteLine(string.Format("I understand. Agent {0} take mission {1} with status {2}",Name,_operation, _status));
        }
    }
}
