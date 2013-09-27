using RunPattern;

namespace PatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Run runner;
            // = new SomeBasicElemnts.WeaponRunner();
            runner = new Observer.RunObserver();

            runner.RunApp();
        }
    }
}
