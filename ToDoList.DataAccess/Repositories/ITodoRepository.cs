using System;
using System.Collections.Generic;
using ToDoList.DataAccess.Models;

namespace ToDoList.DataAccess.Repositories
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> GetAll();
        
        Todo Create(Todo todo);

        void Delete(Guid id);

        void Update(Guid id, Todo todo);
    }
}
