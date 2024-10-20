using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI_.DTOs.BannerDtos;
using OnlineEdu.WebUI_.Helpers;

namespace OnlineEdu.WebUI_.ViewComponents.Home
{
    public class _HomeBannerComponent:ViewComponent
    {
        private readonly HttpClient _client =HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var values = await _client.GetFromJsonAsync<List<ResultBannerDto>>("banners");
            return View(values);
        }
    }
}
