using Microsoft.AspNetCore.Mvc;

namespace Villa_Web.Controllers
{
    public class example : Controller
    {
        public IActionResult Index(int l)
        {
            ViewResult a = new ViewResult();
            
               return View();
            return Content(l.ToString());
        }
        public IActionResult

    }
}
