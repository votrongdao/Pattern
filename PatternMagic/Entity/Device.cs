#region

// File: Device.cs
// Coder: Sergiy Lischuk
// Created: 15.10.2013  17:01
// Email: evertodante@gmail.com

using RunPattern;

#endregion

namespace PatternMagic.Entity
{
    public enum DeviceStatus
    {
        On,
        Off,
        Processing,
        SavingEnergy
    }

    public abstract class Device
    {
        private IOutputWritter _writter;
        private DeviceStatus _devicestatus;

        protected Device(IOutputWritter writter)
        {
            _writter = writter;
            _devicestatus = DeviceStatus.Off;
        }

        public void SwitchOn()
        {
            if (_devicestatus==DeviceStatus.Off)
            {
                _devicestatus = DeviceStatus.On;
            }
            WriteInfo();
        }

        public void SwithOff()
        {
            if (!Equals(_devicestatus, DeviceStatus.Off))
            {
                _devicestatus = DeviceStatus.Off;
            }
            WriteInfo();
        }

        private void WriteInfo()
        {
            _writter.WriteLine(string.Format("Device status: {0}\n", _devicestatus));
        }
    }
}