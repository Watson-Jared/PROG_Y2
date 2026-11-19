using BookLibrary;
using Microsoft.AspNetCore.Mvc;

namespace BookMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService _service;

        public BookController(BookService service)
        {
            _service = service;
        }

     
        public IActionResult Index()
        {
            var books = _service.GetAll();
            return View(books);
        }


        public IActionResult Details(int id)
        {
            var book = _service.GetById(id);
            if (book is null) return NotFound();
            return View(book);
        }
    }
}
