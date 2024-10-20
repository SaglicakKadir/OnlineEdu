using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI_.DTOs.CourseDtos;
using OnlineEdu.WebUI_.Helpers;

namespace OnlineEdu.WebUI_.ViewComponents.Home
{
    public class _HomeCourseComponent:ViewComponent
    {
        private readonly HttpClient _client =HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultCourseDto>>("courses/GetActiveCourses");
            return View(values);
        }
    }
}
