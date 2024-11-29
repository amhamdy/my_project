using cairo_library.Iinterface;
using cairo_library.Models;
using Microsoft.AspNetCore.Mvc;

namespace cairo_library.Controllers
{
    public class checkout : Controller
    {

        private readonly Icheckout _checkout;
        public checkout(Icheckout checkout)
        {
            _checkout=checkout;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Getallcheckoutbooks()
        {

            var checkoutbook = _checkout.Getallcheckoutbooks();
            return View(checkoutbook);

        }
    }
}
