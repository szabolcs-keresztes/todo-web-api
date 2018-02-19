using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ToDoList.DataAccess;
using ToDoList.DataAccess.Models;

namespace ToDoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly ITodoRepository todoRepository;

        public TodoController()
        {
            todoRepository = TodoRepository.Instance;
        }

        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            return this.todoRepository.GetAll();
        }

        [HttpPost]
        public Todo Post([FromBody] Todo todo)
        {
            return this.todoRepository.Create(todo);
        }

        [HttpPut("{id}")]
        public void Put(Guid? id, [FromBody] Todo todo)
        {
            this.todoRepository.Update(id ?? Guid.Empty, todo);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid? id)
        {
            this.todoRepository.Delete(id ?? Guid.Empty);
        }
    }
}