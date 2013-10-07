using Observer.Interfaces;
using RunPattern;

namespace Observer
{
    public class RunObserver:Run
    {
        /// <summary>
        /// Create HQ and add some agent to it 
        /// When hq start new Operation "London Take Down"
        /// </summary>
        public override void RunApp()
        {
            IOutputWritter outputWritter = new ConsoleWritter();
            


            var hq = new HeadQuartes();
            IObserver jamesbond = new James("James Bond", outputWritter);
            IObserver tanyaRomanova = new Tanya("Romanova Tanya", outputWritter);

            hq.RegisterNewSpy(jamesbond);
            hq.RegisterNewSpy(tanyaRomanova);

            hq.ChangeOperation("London Take Down");
            hq.ChangeStatus("Active");

            hq.NotifyAllSpys();
            hq.AgentRepeat();
            
        }
    }
}
