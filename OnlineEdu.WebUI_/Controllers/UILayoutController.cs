using Microsoft.AspNetCore.Mvc;

namespace OnlineEdu.WebUI_.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Layout()
        {
            return View();
        }
    }
}
