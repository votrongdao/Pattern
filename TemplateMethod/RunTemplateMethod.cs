// File: RunTemplateMethod.cs
// Coder: Sergiy Lischuk
// Created: 03:10:2013  17:39
// Email: evertodante@gmail.com

#region

using RunPattern;
using TemplateMethod.Abstraction;
using TemplateMethod.Items;

#endregion

namespace TemplateMethod
{
    public class RunTemplateMethod : Run
    {
        public override void RunApp()
        {
            IOutputWritter writter = new ConsoleWritter();

            PostBehavior email = new Email(writter, "Max@gmail.com", "Me@gmail.com", "Today Lection");
            PostBehavior letter = new Letter(writter, "Mr Write. ", "Santa Claus. North Pole, str. MainHall 1");

            email.SendPost();
            writter.WriteLine("\n");
            writter.WriteLine(email.ToString());
            writter.WriteLine("\n");

            letter.SendPost();
            writter.WriteLine("\n");
            writter.WriteLine(letter.ToString());
            writter.WriteLine("\n");
        }
    }
}