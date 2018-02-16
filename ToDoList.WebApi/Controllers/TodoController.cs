using Microsoft.AspNetCore.Mvc;
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
        public void Post([FromBody] Todo todo)
        {
            this.todoRepository.Add(todo);
        }
    }
}