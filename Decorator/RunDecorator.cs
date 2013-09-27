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
           //Need for Speed !!!
            Car car = new BatmanCar();
            Console.WriteLine(car.GetDescription()+" "+car.Price());

            car = new TurboEngine(car);
            Console.WriteLine(car.GetDescription() + " " + car.Price());

            car = new FastTransmission(car);
            Console.WriteLine(car.GetDescription() + " " + car.Price());

            car = new AbSsystems(car);
            Console.WriteLine(car.GetDescription() + " " + car.Price());
        }
    }
}
