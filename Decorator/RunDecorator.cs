using System;
using Decorator.Cars;
using Decorator.Updates;
using RunPattern;

namespace Decorator
{
    public class RunDecorator:Run
    {
        public override void RunApp()
        {
            IOutputWritter writter = new ConsoleWritter();
           //Need for Speed !!!
            Car car = new BatmanCar();
            writter.WriteLine(car.GetDescription()+" "+car.Price());

            car = new TurboEngine(car);
            writter.WriteLine(car.GetDescription() + " " + car.Price());

            car = new FastTransmission(car);
            writter.WriteLine(car.GetDescription() + " " + car.Price());

            car = new AbSsystems(car);
            writter.WriteLine(car.GetDescription() + " " + car.Price());
        }
    }
}
