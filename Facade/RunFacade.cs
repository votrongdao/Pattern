using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Implementation;
using RunPattern;

namespace Facade
{
    public class RunFacade:Run
    {
        /// <summary>
        /// In real case we need write too much
        /// <code>
        /// Car car = new Car()
        /// car.transmisson = N;
        /// car.engine = on;
        /// car.stereo = on;
        /// car.setvolume = 5;
        /// </code>
        /// </summary>
        public override void RunApp()
        {
            IOutputWritter writter = new ConsoleWritter();
            var car = new CarsFacade(new Engine(writter),new Stereo(writter), new Transmission(writter) );

            //but now - only 2 methods
            car.StrartMoving();
            writter.WriteLine("\n");
            car.StopMoving();

        }
        
    }
}
