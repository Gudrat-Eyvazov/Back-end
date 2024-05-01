using Microsoft.AspNetCore.Mvc;
using My_Cinema_Project.Models;
using System.Diagnostics;

namespace My_Cinema_Project.Controllers
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
            //List<Slider> sliders = new List<Slider>();
            //Slider slider = new Slider
            //{
            //    Id = 1,

            //    ImgUrl =""
            //};
            //Slider slider1 = new Slider
            //{
            //    Id = 2,

            //    ImgUrl = ""
            //};




            //sliders.Add(slider);
            //sliders.Add(slider1);

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
