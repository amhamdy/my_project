using cairo_library.Iinterfaces;
using cairo_library.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace cairo_library.Controllers
{

    public class BookController : Controller
    {

        private readonly Ibook _ibook;
        public BookController(Ibook ibook)
        {
            _ibook = ibook;
        }


        public IActionResult Index()
        {
            return View();


        }

        public IActionResult Getallbooks()
        {
            var Items = _ibook.Getallbooks();
            return View(Items);

        }


        public IActionResult ADDBOOK()
        {


            return View();
        }

        //[HttpPost]
        //public IActionResult creat(books book)
        //{
        //    _ibook.addbook(book);

        //    return RedirectToAction("Getallbooks");
        //}

        [HttpPost]
        public IActionResult Create(books book)
        {
            _ibook.addbook(book);

            return RedirectToAction("Getallbooks");
        }

        //[HttpGet]
        //public IActionResult Edit()
        //{
        //    //var books = _ibook.getbookbyauthor(author);
        //    //return View();
        //}
        //[HttpPost]
        //public IActionResult Edit(books book)
        //{
        //    _ibook.editbook(book);

        //    return RedirectToAction("Getallbooks");

        //}

        public IActionResult getbookbyauthor(string author)
        {
            var books = _ibook.getbookbyauthor(author);
            return View(books);

        }


    }

}
