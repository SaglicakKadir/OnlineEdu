﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Entity.Entities;
using OnlineEdu.WebUI_.DTOs.CourseDtos;
using OnlineEdu.WebUI_.Helpers;

namespace OnlineEdu.WebUI_.Areas.Teacher.Controllers
{
    [Authorize(Roles ="Teacher")]
    [Area("Teacher")]
    public class MyCourseController : Controller
    {
        private readonly HttpClient _client=HttpClientInstance.CreateClient();
        private readonly UserManager<AppUser> _userManager;

        public MyCourseController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = await _client.GetFromJsonAsync<List<ResultCourseDto>>("Courses/GetCoursesByTeacherId/" + user.Id);
            return View(values);
        }
    }
}
