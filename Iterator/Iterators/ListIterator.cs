#region

// File: ListIterator.cs
// Coder: Sergiy Lischuk
// Created: 07:10:2013  19:14
// Email: evertodante@gmail.com

using System;
using System.Collections.Generic;
using Iterator.Entity;
using Iterator.Interface;

#endregion

namespace Iterator.Iterators
{
    /// <summary>
    /// Iterator for a list realization
    /// </summary>
    public class ListIterator : IIterator
    {
        private readonly List<Task> _tasks;
        private int _current;

        public ListIterator(List<Task> tasks)
        {
            _tasks = tasks;
            _current = 0;
        }

        public bool HasNext()
        {
            return _current < _tasks.Count && _tasks[_current] != null;
        }

        public object Next()
        {
           var t = _tasks[_current];
           _current++;
            return t;
        }
    }
}