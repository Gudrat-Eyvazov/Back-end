using Microsoft.AspNetCore.Mvc;
using MyTravelProject.Models;
using System.Diagnostics;

namespace MyTravelProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ExtraService()
        {
            return View();
        }
        public IActionResult Destinations()
        {
            return View();
        }
        public IActionResult FlightInformations()
        {
            return View();
        }
        public IActionResult HotelReservation()
        {
            return View();
        }
        public IActionResult OfflineRequest()
        {
            return View();
        }
        public IActionResult Reservation()
        {
            return View();
        }
        public IActionResult HotelView()
        {
            return View();
        }
        public IActionResult ReservationDetails()
        {
            return View();
        }
        public IActionResult TicketReservation()
        {
            return View();
        }
        public IActionResult TicketSearch()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
