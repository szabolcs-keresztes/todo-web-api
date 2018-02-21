using System;
using System.Collections.Generic;
using ToDoList.DataAccess.Models;

namespace ToDoList.BusinessLogic
{
    public interface ITodoService
    {
        IEnumerable<Todo> GetAll();

        Todo Create(Todo todo);

        void Delete(Guid id);

        void Update(Guid id, Todo todo);
    }
}
