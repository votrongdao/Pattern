#region

// File: RunDecorator.cs
// Coder: Sergiy Lischuk
// Created: 27:09:2013  15:04
// Email: evertodante@gmail.com

using Decorator.Cars;
using Decorator.Updates;
using RunPattern;

#endregion

namespace Decorator
{
    public class RunDecorator : Run
    {
        public override void RunApp()
        {
            IOutputWritter writter = new ConsoleWritter();
            //Need for Speed !!!
            Car car = new BatmanCar();
            writter.WriteLine(car.GetDescription() + " " + car.Price());

            car = new TurboEngine(car);
            writter.WriteLine(car.GetDescription() + " " + car.Price());

            car = new FastTransmission(car);
            writter.WriteLine(car.GetDescription() + " " + car.Price());

            car = new AbSsystems(car);
            writter.WriteLine(car.GetDescription() + " " + car.Price());
        }
    }
}