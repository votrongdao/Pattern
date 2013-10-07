using RunPattern;

namespace Observer
{
    public class Tanya:SpyAgent
    {
        /// <summary>
        /// Case of Agent (Aegnt Tanya)
        /// </summary>
        /// <param name="name">Agent names</param>
        /// <param name="writter">Output</param>
        public Tanya(string name, IOutputWritter writter) : base(name, writter)
        {
        }
    }
}
