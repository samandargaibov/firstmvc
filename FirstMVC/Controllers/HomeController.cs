using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
