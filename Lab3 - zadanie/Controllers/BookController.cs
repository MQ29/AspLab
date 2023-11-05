using Lab3zadanie.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3zadanie.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            return View(_bookService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book model)
        {
            if (ModelState.IsValid)
            {
                _bookService.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_bookService.FindById(id));
        }

        [HttpPost]
        public IActionResult Update(Book model)
        {
            if (ModelState.IsValid)
            {
                _bookService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_bookService.FindById(id));
        }   

        [HttpPost]
        public IActionResult Delete(Book model)
        {
            _bookService.Delete(model.Id);
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            return View(_bookService.FindById(id));
        }
    }
}
