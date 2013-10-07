using System.Collections.Generic;
using Observer.Interfaces;

namespace Observer
{
    /// <summary>
    /// Realization hq. This class will be a subject what implement Isubject interface 
    /// </summary>
    public class HeadQuartes : ISubject
    {
        private readonly HashSet<IObserver> _spyAgent;
        private string _curentOperation;
        private string _status;

        public HeadQuartes()
        {
            _spyAgent = new HashSet<IObserver>();
        }

        public void RegisterNewSpy(IObserver agent)
        {
            _spyAgent.Add(agent);
        }

        public void RemoveSpy(IObserver agent)
        {
            _spyAgent.Remove(agent);
        }

        public void NotifyAllSpys()
        {
            foreach (var agent in _spyAgent)
            {
                agent.UpdateInformation(_status, _curentOperation);
            }
        }


        public void ChangeStatus(string status)
        {
            _status = status;
        }

        public void ChangeOperation(string operation)
        {
            _curentOperation = operation;
        }

        public void AgentRepeat()
        {
            foreach (var agent in _spyAgent)
            {
                agent.Confirm();
            }
        }
    }
}
