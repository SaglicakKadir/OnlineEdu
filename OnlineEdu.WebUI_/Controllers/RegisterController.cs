using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI_.DTOs.UserDtos;
using OnlineEdu.WebUI_.Services.UserServices;

namespace OnlineEdu.WebUI_.Controllers
{
    public class RegisterController(IUserService _userService) : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterDto userRegisterDto) 
        {
            var result =await _userService.CreateUserAsnyc(userRegisterDto);
            if(!result.Succeeded) 
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.Code, item.Description);
                }
                return View();
            }
            return RedirectToAction("Index", "Login");
        }
    }
}
