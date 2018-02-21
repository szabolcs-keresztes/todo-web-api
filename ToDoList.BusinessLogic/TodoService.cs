using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.DataAccess.Models;
using ToDoList.DataAccess.Repositories;

namespace ToDoList.BusinessLogic
{
    public class TodoService : ITodoService
    {
        private ITodoRepository todoRepository;

        public TodoService()
        {
            this.todoRepository = TodoRepository.Instance;
        }

        public Todo Create(Todo todo)
        {
            return this.todoRepository.Create(todo);
        }

        public void Delete(Guid id)
        {
            this.todoRepository.Delete(id);
        }

        public IEnumerable<Todo> GetAll()
        {
            return this.todoRepository.GetAll();
        }

        public void Update(Guid id, Todo todo)
        {
            this.todoRepository.Update(id, todo);
        }
    }
}
