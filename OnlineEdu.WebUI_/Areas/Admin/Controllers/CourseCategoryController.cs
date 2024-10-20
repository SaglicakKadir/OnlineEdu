﻿using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI_.DTOs.CourseCategoryDtos;
using OnlineEdu.WebUI_.Helpers;

namespace OnlineEdu.WebUI_.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class CourseCategoryController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultCourseCategoryDto>>("CourseCategories");
            return View(values);
        }

        public async Task<IActionResult> DeleteCourseCategory(int id)
        {
            await _client.DeleteAsync($"CourseCategories/" + id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateCourseCategory()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCourseCategory(CreateCourseCategoryDto createCourseCategoryDto)
        {
            await _client.PostAsJsonAsync("CourseCategories", createCourseCategoryDto);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateCourseCategory(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateCourseCategoryDto>("CourseCategories/" + id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCourseCategory(UpdateCourseCategoryDto updateCourseCategoryDto)
        {
            await _client.PutAsJsonAsync("CourseCategories", updateCourseCategoryDto);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> ShowOnHome(int id)
        {
            await _client.GetAsync("CourseCategories/ShowOnHome/" + id);
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> DontShowOnHome(int id)
        {
            await _client.GetAsync("CourseCategories/DontShowOnHome/" + id);
            return RedirectToAction("Index");
        }
    }
}