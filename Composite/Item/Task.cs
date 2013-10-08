// File: Task.cs
// Coder: Sergiy Lischuk
// Created: 08:10:2013  20:43
// Email: evertodante@gmail.com

using System.Collections.Generic;
using RunPattern;

namespace Composite.Item
{
    /// <summary>
    /// Simple class for understanding behavior
    /// </summary>
    public class Task:AbstractBehavior
    {
        public string Name { get; private set; }
        public string Do { get; private set; }
        private IOutputWritter _writter;

        private readonly List<AbstractBehavior> _behavior;

        public Task(string @do, string name, IOutputWritter writter)
        {
            Name = name;
            _writter = writter;
            Do = @do;
            _behavior = new List<AbstractBehavior>();
        }

        public override void Add(AbstractBehavior itemTask)
        {
            _behavior.Add(itemTask);
        }

        public override void Remove(AbstractBehavior item)
        {
            _behavior.Remove(item);
        }

        public override string ToString()
        {
            return string.Format("This task has name - {0}, need do only:{1}", Name, Do);
        }

        public override void GetSub()
        {
            foreach (AbstractBehavior behavior in _behavior)
            {
                _writter.WriteLine(behavior.ToString());
            }
        }

     
    }
}