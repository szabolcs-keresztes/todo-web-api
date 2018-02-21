using System;
using System.Collections.Generic;
using ToDoList.DataAccess.Models;

namespace ToDoList.DataAccess
{
    public class InMemoryStorage
    {
        private static volatile InMemoryStorage instance;
        private static object syncRoot = new Object();

        private IList<Todo> todos;

        private InMemoryStorage()
        {
            todos = new List<Todo>
            {
                new Todo
                {
                    Id = Guid.NewGuid(),
                    Name = "First Task",
                },
                new Todo
                {
                    Id = Guid.NewGuid(),
                    Name = "Second Task",
                    IsCompleted = true
                },
                new Todo
                {
                    Id = Guid.NewGuid(),
                    Name = "Third Task",
                },
            };
        }

        public static InMemoryStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new InMemoryStorage();
                    }
                }

                return instance;
            }
        }
            
    }
}
