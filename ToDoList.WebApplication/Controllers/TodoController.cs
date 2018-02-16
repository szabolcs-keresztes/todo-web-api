using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.WebApplication.Models;
using ToDoList.WebApplication.Repositories;

namespace ToDoList.WebApplication.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoRepository todoRepository;

        public TodoController()
        {
            todoRepository = TodoRepository.Instance;
        }

        public IActionResult Index()
        {
            return View(this.todoRepository.GetAll());
        }

        // GET: Todo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Todo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Todo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                this.todoRepository.Add(new Todo
                {
                    Id = Guid.NewGuid(),
                    Task = collection["Task"]
                });

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Todo/Edit/5
        public ActionResult Complete(Guid id)
        {
            try
            {
                todoRepository.CompleteTask(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
        // GET: Todo/Delete/5
        public ActionResult Delete(Guid id)
        {
            todoRepository.Remove(id);

            return RedirectToAction(nameof(Index));
        }
    }
}