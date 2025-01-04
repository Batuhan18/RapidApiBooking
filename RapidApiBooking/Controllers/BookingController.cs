using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiBooking.Models;

namespace RapidApiBooking.Controllers
{
    public class BookingController : Controller
    {
        public async Task<IActionResult> HotelList()
        {
            List<BookingModel> model = new List<BookingModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id=-1995499&search_type=CITY&arrival_date=2025-02-19&departure_date=2025-02-24&adults=2&children_age=0%2C17&room_qty=1&page_number=1&units=metric&temperature_unit=c&languagecode=en-us&currency_code=AED"),
                Headers =
    {
        { "x-rapidapi-key", "d4a58d4634mshef481a542f465a0p11b614jsn299da005958a" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                //model = JsonConvert.DeserializeObject<List<BookingModel>>(body);
                Console.WriteLine(body);
                return View(model);
            }
        }
    }
}
