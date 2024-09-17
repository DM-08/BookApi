using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    public class BookingsController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/

        [HttpPost]
        public IActionResult CreateBooking()
        {
            BookingsController.Id = 123;
            return CreatedAtAction(nameof(GetBooking), new { id = BookingsController.Id }, booking);
        }
    }
}
