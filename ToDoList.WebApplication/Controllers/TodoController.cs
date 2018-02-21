using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.DataAccess.Models;
using ToDoList.DataAccess;

namespace ToDoList.WebApplication.Controllers
{
    public class TodoController : Controller
    {
        // This controller is not the main important to keep up to date during development
        // The moment when the business logic is well thought out then will fix this issues here

        //private readonly ITodoRepository todoRepository;

        //public TodoController()
        //{
        //    todoRepository = TodoRepository.Instance;
        //}

        //public IActionResult Index()
        //{
        //    return View(this.todoRepository.GetAll());
        //}

        //// GET: Todo/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Todo/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Todo/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        this.todoRepository.Create(new Todo
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = collection["Task"]
        //        });

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Todo/Edit/5
        //public ActionResult Complete(Guid id)
        //{
        //    try
        //    {
        //        todoRepository.Update(id, new Todo());
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        
        //// GET: Todo/Delete/5
        //public ActionResult Delete(Guid id)
        //{
        //    todoRepository.Delete(id);

        //    return RedirectToAction(nameof(Index));
        //}
    }
}