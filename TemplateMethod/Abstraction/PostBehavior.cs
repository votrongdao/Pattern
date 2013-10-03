// File: PostBehavior.cs
// Coder: Sergiy Lischuk
// Created: 03:10:2013  17:13
// Email: evertodante@gmail.com

#region

using RunPattern;

#endregion

namespace TemplateMethod.Abstraction
{
    public abstract class PostBehavior
    {
        private readonly IOutputWritter _writter;

        protected PostBehavior(IOutputWritter writter)
        {
            _writter = writter;
        }

        public void SendPost()
        {
            WriteMessage();
            PrepareToSending();
            SendMessage();
            WaitAnswer();
        }

        private void WaitAnswer()
        {
            _writter.WriteLine("Now just left only wait a answer");
        }

        protected abstract void SendMessage();

        protected abstract void PrepareToSending();

        protected abstract void WriteMessage();
    }
}