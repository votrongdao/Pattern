using RunPattern;

namespace PatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Run runner;
            // = new SomeBasicElemnts.WeaponRunner();
            // = new Observer.RunObserver();
            // = new Decorator.RunDecorator();
            // = new FactoryMethod.RunFactory();
            //runner = new Command.RunCommand();
            //runner = new Adapter.RunAdapter();
//            runner = new Facade.RunFacade();
            runner = new TemplateMethod.RunTemplateMethod();
            runner.RunApp();
        }
    }
}
