// File: CarsFacade.cs
// Coder: Sergiy Lischuk
// Created: 03:10:2013  15:45
// Email: evertodante@gmail.com

#region

using Facade.Implementation;
using Facade.Interfaces;

#endregion

namespace Facade
{
    /// <summary>
    /// Now we can use only 2 methods for updating these all properties
    /// </summary>
    public class CarsFacade
    {
        private readonly IEngine _engine;
        private readonly IStereo _stereo;
        private readonly ITransmission _transmission;

        public CarsFacade(IEngine engine, IStereo stereo, ITransmission transmission)
        {
            _engine = engine;
            _stereo = stereo;
            _transmission = transmission;
        }

        public void StrartMoving()
        {
            _transmission.SetGear(Gears.N);
            _engine.Start();
            _stereo.On();
            _stereo.SetVolume(5);
        }

        public void StopMoving()
        {
            _transmission.SetGear(Gears.N);
            _engine.Stop();
            _stereo.Off();
        }
    }
}