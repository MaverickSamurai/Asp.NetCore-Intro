using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore_Practice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string FullData(string name, string surname, int age)
        {
            return $"Name-{name}: Surname-{surname}-{age}";
        }
    }
}
