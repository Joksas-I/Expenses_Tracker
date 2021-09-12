using ExpensesTracker.Data;
using ExpensesTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesTracker.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ApplicationDdContext _db;
        public ToDoController(ApplicationDdContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ToDo> objList = _db.ToDoItems;
            return View(objList);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ToDo obj)
        {
            if (ModelState.IsValid)
            {
                _db.ToDoItems.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
