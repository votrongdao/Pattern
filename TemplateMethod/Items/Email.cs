// File: Email.cs
// Coder: Sergiy Lischuk
// Created: 03:10:2013  17:07
// Email: evertodante@gmail.com

#region

using RunPattern;
using TemplateMethod.Abstraction;

#endregion

namespace TemplateMethod.Items
{
    /// <summary>
    /// In our email message other structure whan have simply paper letter
    /// Whats why we need change basic algo for sending email message
    /// 
    /// </summary>
    public class Email : PostBehavior
    {
        private readonly IOutputWritter _writter;

        public Email(IOutputWritter writter, string to, string @from, string theme) : base(writter)
        {
            _writter = writter;
            Theme = theme;
            From = @from;
            To = to;
        }

        public string To { get; private set; }
        public string From { get; private set; }
        public string Text { get; set; }
        public string Theme { get; private set; }

        protected override void SendMessage()
        {
            _writter.WriteLine("Gmail.com -> Send");
        }

        protected override void PrepareToSending()
        {
            _writter.WriteLine("Checking spelling");
        }

        protected override void WriteMessage()
        {
            Text = "Max, can you repeat to me than the lectors says on today lection??";
        }

        public override string ToString()
        {
            return string.Format("Email:\n" +
                                 "From: {0}\n" +
                                 "To: {1}\n" +
                                 "Theme: {2}\n" +
                                 "Text: {3}\n", From, To, Theme, Text);
        }
    }
}