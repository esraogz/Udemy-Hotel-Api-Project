using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Threading.Tasks;

namespace RapidApiConsume.Controllers
{
    public class SearchLocationIDController : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
            if (!string.IsNullOrEmpty(cityName))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={cityName}"),
                    Headers =
    {
        { "x-rapidapi-key", "cf403993c3msh8fd9321184104f1p186179jsn7bb76ffa2c3e" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<BookingSearchLocationViewModel>(body);
                    return View(value.data.Take(1).ToList());
                }
            }
            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query=ankara"),
                    Headers =
    {
        { "x-rapidapi-key", "cf403993c3msh8fd9321184104f1p186179jsn7bb76ffa2c3e" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<BookingSearchLocationViewModel>(body);
                    return View(value.data.Take(1).ToList());
                }
            }

        }
    }
}
