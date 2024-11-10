using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI_.DTOs.AboutDtos;
using OnlineEdu.WebUI_.DTOs.BlogCategoryDtos;
using OnlineEdu.WebUI_.Helpers;
using OnlineEdu.WebUI_.Validators;

namespace OnlineEdu.WebUI_.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class BlogCategoryController : Controller
    {
        private readonly HttpClient _client=HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultBlogCategoryDto>>("blogscategories");
            return View(values);
        }
        public async Task<IActionResult> DeleteBlogCategory(int id)
        {
            await _client.DeleteAsync($"blogcategories/{id}");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateBlogCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlogCategory(CreateBlogCategoryDto createBlogCategoryDto)
        {
            ModelState.Clear();//hata mesajı yerine başka mesaj bırakıyordu önbelleği önceden temizleyerek sorunu çözdük
            var validator=new BlogCategoryValidator();
            var result =await validator.ValidateAsync(createBlogCategoryDto);
            if(!result.IsValid)
            {
                foreach(var x in result.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
                return View();
            }
            await _client.PostAsJsonAsync("blogcategories", createBlogCategoryDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpadateBlogCategory(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateBlogCategoryDto>($"blogcategories/{id}");
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpadateBlogCategory(UpdateBlogCategoryDto updateBlogCategoryDto)
        {
            await _client.PutAsJsonAsync("blogcategories", updateBlogCategoryDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
