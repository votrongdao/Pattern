namespace Decorator.Updates
{
    /// <summary>
    /// Decorate our car with new updates
    /// </summary>
    public class TurboEngine:UpdatingCar
    {
        private readonly Car _car;

        public TurboEngine(Car car)
        {
            _car = car;
        }

        public override double Price()
        {
            return 2000 + _car.Price();
        }

        public override string GetDescription()
        {
            var a = _car.GetDescription();
            return a + " Max Speed up for 20 percent ";
        }
    }
}
