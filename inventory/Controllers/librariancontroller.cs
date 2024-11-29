using cairo_library.Iinterface;
using Microsoft.AspNetCore.Mvc;

namespace cairo_library.Controllers
{
    public class librariancontroller : Controller
    {
        private readonly   Ilibrarian _Ilibrarian;
        public librariancontroller(Ilibrarian  Ilibrarian)
        {
            _Ilibrarian= Ilibrarian;
        }
        public IActionResult Index()
        {
            return View();
        }




        public IActionResult getlibrarians()
        {
           var librarian= _Ilibrarian.getlibrarians();
            return View(librarian);
        }

        
            
        
        public IActionResult addlibrarian()
        {
            return View();
        }
        [HttpPost]
        public IActionResult creat (librariancontroller librarian)
        {
            _Ilibrarian.addlibrarian(librarian);

            return RedirectToAction("getlibrarians");

        }



    }



}
