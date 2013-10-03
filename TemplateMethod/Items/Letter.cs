// File: Letter.cs
// Coder: Sergiy Lischuk
// Created: 03:10:2013  17:06
// Email: evertodante@gmail.com

#region

using RunPattern;
using TemplateMethod.Abstraction;

#endregion

namespace TemplateMethod.Items
{
    /// <summary>
    /// Change realization for post letter
    /// </summary>
    public class Letter : PostBehavior
    {
        private readonly IOutputWritter _writter;

        public Letter(IOutputWritter writter, string @from, string to) : base(writter)
        {
            _writter = writter;
            To = to;
            From = @from;
        }

        public string To { get; private set; }
        public string From { get; private set; }
        public string Text { get; set; }

        protected override void SendMessage()
        {
            _writter.WriteLine("Get up, wear, and going to post office");
        }

        protected override void PrepareToSending()
        {
            _writter.WriteLine("Cheking spelling");
            _writter.WriteLine("Stick stamps");
        }

        protected override void WriteMessage()
        {
            Text = "Dear Santa. Maybe you didnt recive my letters before.... ";
        }

        public override string ToString()
        {
            return string.Format("Letter:\n" +
                                 "From: {0}\n" +
                                 "To: {1}\n" +
                                 "Text: {2}\n", From, To, Text);
        }
    }
}