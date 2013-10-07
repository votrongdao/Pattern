#region

// File: ListTask.cs
// Coder: Sergiy Lischuk
// Created: 07:10:2013  19:05
// Email: evertodante@gmail.com

using System;
using System.Collections.Generic;
using Iterator.Annotations;
using Iterator.Entity;
using Iterator.Interface;
using Iterator.Iterators;

#endregion

namespace Iterator
{
    /// <summary>
    /// Iterator for list
    /// </summary>
    public class ListTask
    {
        private readonly List<Task> _tasks;

        public ListTask(List<Task> tasks)
        {
            _tasks = tasks;
        }

        public void AddTask([NotNull] Task task)
        {
            if (task == null) throw new ArgumentNullException("task");
            _tasks.Add(task);
        }

        public IIterator GetIterator()
        {
            return new ListIterator(_tasks);
        }
    }
}