using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore_HomeWork.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
