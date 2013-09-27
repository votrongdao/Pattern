using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interfaces
{
    /// <summary>
    /// This interface will be implement by our "observers" - spy agent
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Spy need know about situation
        /// </summary>
        void UpdateInformation(string status, string operation);

        /// <summary>
        /// All agent must repeat status and operation for understanding information
        /// </summary>
        void Confirm();
    }
}
