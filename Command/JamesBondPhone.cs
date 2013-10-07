using System.Collections.Generic;
using Command.CommandRealization;
using Command.Interfaces;

namespace Command
{
    /// <summary>
    /// This is realization of initiator Class
    /// </summary>
    public class JamesBondPhone
    {
        private List<ICommand> _carCommands; 
        private Car _car;

        /// <summary>
        /// Only for example. In second constructor we send Car such as object - and it a good choise but very 
        /// bad for understanding
        /// </summary>
        public JamesBondPhone()
        {
            _car = new Car();
            _carCommands = new List<ICommand>();
            LoadSimpleCommandList();
        }

        public JamesBondPhone(Car car)
        {
            _car = car;
            _carCommands = new List<ICommand>();
            LoadSimpleCommandList();
        }

        public void AddCommand(ICommand command)
        {
            _carCommands.Add(command);
        }

        private void LoadSimpleCommandList()
        {
            _carCommands.Add(new LaunchRocket(_car.RocketBarrage));
            _carCommands.Add(new TurnOnStereo(_car.Stereo));
            _carCommands.Add(new SetFavoriteVolume(_car.Stereo));
            _carCommands.Add(new StartEngine(_car.Engine));
            _carCommands.Add(new SetTransmittionToAutoMode(_car.Transmission));
        }

        public void RunCommand(int i)
        {
            _carCommands[i].Execute();
        }

    }
}
