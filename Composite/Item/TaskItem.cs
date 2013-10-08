#region

// File: TaskItem.cs
// Coder: Sergiy Lischuk
// Created: 08:10:2013  21:17
// Email: evertodante@gmail.com

using System;

#endregion

namespace Composite.Item
{
    /// <summary>
    /// This also need inherits AbstractBehavior
    /// </summary>
    public class TaskItem : AbstractBehavior
    {
        public TaskItem(DateTime start, string whosTask)
        {
            WhosTask = whosTask;
            Start = start;
        }

        public string WhosTask { get; private set; }
        public DateTime Start { get; private set; }

        public override string ToString()
        {
            return string.Format("Start date: {0}, responsible - {1}", Start.ToShortTimeString(), WhosTask);
        }
    }
}