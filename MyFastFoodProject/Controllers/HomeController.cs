using Microsoft.AspNetCore.Mvc;
using MyFastFoodProject.DAL;
using MyFastFoodProject.Models;
using System.Diagnostics;

namespace MyFastFoodProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AppDbContext appDbContext;
        public HomeController(ILogger<HomeController> logger, AppDbContext _appDbContext)
        {
            _logger = logger;
            appDbContext = _appDbContext;
        }

        public IActionResult Index()
        {
            //List<Slider>sliderlist = new List<Slider>();
        
            return View(appDbContext.Sliders.Where(x=>x.IsCheck !=false).ToList());
        }
        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult ContactAs()
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
