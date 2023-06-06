using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.DtoLayer.ProductDtos;
using System.ComponentModel;

namespace RealHouizng.Consume.ViewComponents.Default
{
    public class _PropertiesPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _PropertiesPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44369/api/Product");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
