using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ToDoList.BusinessLogic;
using ToDoList.DataAccess;
using ToDoList.DataAccess.Models;

namespace ToDoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly ITodoService todoService;

        public TodoController(ITodoService todoService)
        {
            this.todoService = todoService;
        }

        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            return this.todoService.GetAll();
        }

        [HttpPost]
        public Todo Post([FromBody] Todo todo)
        {
            return this.todoService.Create(todo);
        }

        [HttpPut("{id}")]
        public void Put(Guid? id, [FromBody] Todo todo)
        {
            this.todoService.Update(id ?? Guid.Empty, todo);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid? id)
        {
            this.todoService.Delete(id ?? Guid.Empty);
        }
    }
}