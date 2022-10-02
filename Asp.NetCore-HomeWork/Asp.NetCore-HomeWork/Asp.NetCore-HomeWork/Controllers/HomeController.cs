using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore_HomeWork.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
