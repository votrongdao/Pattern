namespace Decorator.Cars
{
    /// <summary>
    /// Realization basis decorator. Our Car will be changed with work process
    /// </summary>
    public class BatmanCar:Car
    {
        public BatmanCar()
        {
            Description = "I`m Batman car!!!";
        }
        public override double Price()
        {
            return 200.00;
        }
    }
}
