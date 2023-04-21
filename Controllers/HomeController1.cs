using Microsoft.AspNetCore.Mvc;

namespace systemquchooch.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
