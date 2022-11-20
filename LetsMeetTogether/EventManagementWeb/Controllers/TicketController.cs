using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace EventManagementWeb.Controllers
{
    public class TicketController : Controller
    {
        private readonly HttpClient _httpClient;

        public TicketController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:5225/");
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("Event");
            //List <EventViewModel> events  = null;
            if (response.IsSuccessStatusCode)
            {
                //events = JsonConvert.DeserializeObject<List<EventViewModel>>(response.Content.ReadAsStringAsync().Result);

                string data = await response.Content.ReadAsStringAsync();
                JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                //List<EventAPIViewModel> eventViewModels = JsonSerializer.Deserialize<List<EventAPIViewModel>>();

            }

            return View();
        }
    }
}
