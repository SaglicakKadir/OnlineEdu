using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI_.Models;
using System.Diagnostics;

namespace OnlineEdu.WebUI_.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
