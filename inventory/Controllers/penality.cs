using cairo_library.Iinterface;
using Microsoft.AspNetCore.Mvc;

namespace cairo_library.Controllers
{
    public class penality : Controller
    {
        private readonly Ipenality _penality;

        public penality(Ipenality  penality)

        {

            _penality = penality;
            
        }






        public IActionResult Index()
        {
            
            return View();
        }




        public IActionResult getpenality()
        {
            var penality = _penality.getpenality();

            return View(penality); 
       
        }

        public IActionResult addpenality()
        {

            return View();

        }



    }



}
