using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.DataAccess.Models;

namespace ToDoList.DataAccess
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

        public Todo Create(Todo todo)
        {
            todos.Add(todo);

            return todo;
        }

        public void Delete(Guid id)
        {
            var todoToRemove = todos.FirstOrDefault(todo => todo.Id == id);
            todos.Remove(todoToRemove);
        }

        public void Update(Guid id, Todo updatedTodo)
        {
            var todoToUpdate = todos.FirstOrDefault(todo => todo.Id == id);
            
            if (todoToUpdate != null)
            {
                todoToUpdate.Name = updatedTodo.Name;
                todoToUpdate.IsCompleted = updatedTodo.IsCompleted;
            }
        }
    }
}
