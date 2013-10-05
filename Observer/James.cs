using RunPattern;

namespace Observer
{
    public class James:SpyAgent
    {
        /// <summary>
        /// Case of agent. 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="writter"></param>
        public James(string name, IOutputWritter writter) : base(name, writter)
        {
        }
    }
}
