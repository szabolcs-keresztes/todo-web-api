using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.WebApplication.Models;

namespace ToDoList.WebApplication.Repositories
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
