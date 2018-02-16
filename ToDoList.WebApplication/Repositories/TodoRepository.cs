using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.WebApplication.Models;

namespace ToDoList.WebApplication.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private static volatile TodoRepository instance;
        private static object syncRoot = new Object();

        private IList<Todo> todos;

        private TodoRepository()
        {
            todos = new List<Todo>
            {
                new Todo
                {
                    Id = Guid.NewGuid(),
                    Task = "First Task",
                },
                new Todo
                {
                    Id = Guid.NewGuid(),
                    Task = "Second Task",
                    IsCompleted = true
                },
                new Todo
                {
                    Id = Guid.NewGuid(),
                    Task = "Third Task",
                },
            };
        }

        public static TodoRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new TodoRepository();
                    }
                }

                return instance;
            }
        }

        public IEnumerable<Todo> GetAll()
        {
            return todos;
        }

        public Todo GetById(Guid id)
        {
            return todos.FirstOrDefault(todo => todo.Id == id);
        }

        public void Add(Todo todo)
        {
            todos.Add(todo);
        }

        public void Remove(Guid id)
        {
            var todoToRemove = todos.FirstOrDefault(todo => todo.Id == id);
            todos.Remove(todoToRemove);
        }

        public void CompleteTask(Guid id)
        {
            var todoToComplete = todos.FirstOrDefault(todo => todo.Id == id);
            todoToComplete.IsCompleted = true;
        }
    }
}
