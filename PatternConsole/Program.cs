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
            runner = new Decorator.RunDecorator();
                

            runner.RunApp();
        }
    }
}
