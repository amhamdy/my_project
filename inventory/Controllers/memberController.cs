using cairo_library.Iinterface;
using cairo_library.Models;
using Microsoft.AspNetCore.Mvc;

namespace cairo_library.Controllers
{
    
    public class memberController : Controller
    {
        private readonly Imember _member;
        public memberController(Imember member)
        {
            _member = member;
        }



        public IActionResult Index()
        {
            return View();


        }
        public IActionResult getallmember()
        {
            var members = _member.getallmember();

            return View(members);
        }

        [HttpPost]
        public IActionResult creat (member member)

        {
            _member.addmember(member);
            return RedirectToAction("getallmember");
        }
        public IActionResult  addmember ()
            { return View(); }

    }
}
