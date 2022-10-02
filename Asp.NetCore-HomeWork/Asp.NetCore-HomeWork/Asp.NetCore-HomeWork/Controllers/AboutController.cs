using Microsoft.AspNetCore.Mvc;


namespace Asp.NetCore_HomeWork.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
