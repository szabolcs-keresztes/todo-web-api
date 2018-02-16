using System;
using System.Collections.Generic;
using ToDoList.DataAccess.Models;

namespace ToDoList.DataAccess
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> GetAll();

        Todo GetById(Guid id);

        void Add(Todo todo);

        void Remove(Guid id);

        void CompleteTask(Guid id);
    }
}
