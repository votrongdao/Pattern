#region

// File: RunIterator.cs
// Coder: Sergiy Lischuk
// Created: 07:10:2013  18:53
// Email: evertodante@gmail.com

using System;
using System.Collections.Generic;
using Iterator.Entity;
using Iterator.Interface;
using RunPattern;

#endregion

namespace Iterator
{
    public class RunIterator : Run
    {
        private IOutputWritter _output;

        public override void RunApp()
        {
            _output = new ConsoleWritter();

            var task1 = new Task(true, "first task", DateTime.Now, DateTime.MaxValue);

            var task2 = new Task(false, "Second task", DateTime.Now, DateTime.Now.Add(new TimeSpan(0, 15, 0)));
            
            var list = new ListTask(new List<Task>());
            list.AddTask(task1);
            list.AddTask(task2);

            _output.WriteLine("List task///");
            var iteratorlist = list.GetIterator();
            while (iteratorlist.HasNext())
            {
                _output.WriteLine(iteratorlist.Next().ToString());
            }


            _output.WriteLine("Array task///");

            var task = new ArrayTask(new[]{task1,task2}, 0);
            iteratorlist = task.ArrayIterator();
            while (iteratorlist.HasNext())
            {
                _output.WriteLine(iteratorlist.Next().ToString());
            }
            
        }
    }
}