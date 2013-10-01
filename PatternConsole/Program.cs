using RunPattern;

namespace PatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Run runner;
            // = new SomeBasicElemnts.WeaponRunner();
            //= new Observer.RunObserver();
            // = new Decorator.RunDecorator();
            runner = new FactoryMethod.RunFactory();
                

            runner.RunApp();
        }
    }
}
