namespace Decorator.Cars
{
    /// <summary>
    /// Such as <see cref="BatmanCar"/>
    /// </summary>
    public class Nissan:Car
    {
       public Nissan()
       {
           Description = "Nissan is a good car from you dream!!!"; //yea - my dream is Aston Martin DB9!
       }
        public override double Price()
        {
            return 100.00;
        }
    }
}
