using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI_.DTOs.SocialMediaDtos;
using OnlineEdu.WebUI_.Helpers;

namespace OnlineEdu.WebUI_.ViewComponents.UILayout
{
    public class _UILayoutHeaderSocialMediaComponent:ViewComponent
    {
        private readonly HttpClient _client=HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultSocialMediaDto>>("socialMedias");
            return View(values);
        }
    }
}
