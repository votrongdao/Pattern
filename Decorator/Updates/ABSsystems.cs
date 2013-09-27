namespace Decorator.Updates
{
    /// <summary>
    /// Such as <see cref="TurboEngine"/>
    /// </summary>
    class AbSsystems:UpdatingCar
    {
        private readonly Car _car;

        public AbSsystems(Car car)
        {
            _car = car;
        }

        public override double Price()
        {
            return _car.Price() + 1500;
        }

        public override string GetDescription()
        {
            return _car.GetDescription() + " Controllability + 10%";
        }
    }
}
