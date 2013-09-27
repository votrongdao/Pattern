namespace Decorator.Updates
{
    /// <summary>
    /// Such as <see cref="TurboEngine"/>
    /// </summary>
    public class FastTransmission:UpdatingCar
    {
        private readonly Car _car;

        public FastTransmission(Car car)
        {
            _car = car;
        }

        public override double Price()
        {
            return _car.Price() + 2500;
        }

        public override string GetDescription()
        {
            return _car.GetDescription() + " Acceleration up by 25%";
        }
    }
}
