﻿using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI_.DTOs.UserDtos;
using OnlineEdu.WebUI_.Services.UserServices;

namespace OnlineEdu.WebUI_.Controllers
{
    public class LoginController(IUserService _userService) : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginDto userLoginDto)
        {
            var userRole =await _userService.LoginAsync(userLoginDto);
            if (userRole == "Admin")
            {
                return RedirectToAction("Index","About", new {area="Admin"});
            }

            if (userRole == "Teacher")
            {
                return RedirectToAction("Index", "MyCourse", new { area = "Teacher" });
            }

            if (userRole == "Student")
            {
                return RedirectToAction("Index", "CourseRegister", new { area = "Student" });
            }

            else
            {
                ModelState.AddModelError("", "Email veya şifre hatalı!");
                return View();
            }
        }
    }
}