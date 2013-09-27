using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interfaces
{
    /// <summary>
    /// Its a simple implementation of subject. In our case we will be know 
    /// what our "HQ" must realize this interface for controls agent
    /// </summary>
    interface ISubject
    {
        void RegisterNewSpy(IObserver agent);
        void RemoveSpy(IObserver agent);
        void NotifyAllSpys();
    }
}
