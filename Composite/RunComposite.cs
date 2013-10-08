#region

// File: RunComposite.cs
// Coder: Sergiy Lischuk
// Created: 08:10:2013  17:19
// Email: evertodante@gmail.com

using System;
using Composite.Item;
using RunPattern;

#endregion

namespace Composite
{
    public class RunComposite : Run
    {
        public override void RunApp()
        {
            IOutputWritter writter = new ConsoleWritter();
            AbstractBehavior abstractBehavior = new Task("Send Me mail", "James", writter);
            abstractBehavior.Add(new TaskItem(DateTime.Now, "James willson"));
            abstractBehavior.Add(new TaskItem(DateTime.Now, "Gregory House"));
            abstractBehavior.Add(new Task("Get up server tasking", "Operation 'No steps back'", writter));

            abstractBehavior.GetSub();

            writter.WriteLine(abstractBehavior.ToString());
        }
    }
}