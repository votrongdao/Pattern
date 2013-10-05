using RunPattern;

namespace PatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Run runner;
//            runner = new SomeBasicElemnts.WeaponRunner();
//           runner = new Observer.RunObserver();
//            runner = new Decorator.RunDecorator();
            runner = new FactoryMethod.RunFactory();
            //runner = new Command.RunCommand();
            //runner = new Adapter.RunAdapter();
//            runner = new Facade.RunFacade();
            //runner = new TemplateMethod.RunTemplateMethod();
            runner.RunApp();
        }
    }
}
