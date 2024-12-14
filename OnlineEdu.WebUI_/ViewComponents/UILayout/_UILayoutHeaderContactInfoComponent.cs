using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI_.DTOs.ContactDtos;
using OnlineEdu.WebUI_.Helpers;

namespace OnlineEdu.WebUI_.ViewComponents.UILayout
{
    public class _UILayoutHeaderContactInfoComponent:ViewComponent
    {
        private readonly HttpClient _client=HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultContactDto>>("contacts");
            return View(values);
        }
    }
}
