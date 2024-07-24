using Microsoft.AspNetCore.Mvc;
using MyFastFoodProject.DAL;
using MyFastFoodProject.Models;
using MyFastFoodProject.Models.ViewModels;
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
            HomeVM homeVM = new HomeVM
            {
                SliderList = appDbContext.Sliders.Where(x => x.IsCheck == true).ToList(),
                ProductList = appDbContext.Products.Where(x => x.IsActive == true).ToList()
            };


            return View(homeVM);
        }
        public IActionResult Menu()
        {
            HomeVM homeVM = new HomeVM
            {
                SliderList = appDbContext.Sliders.Where(x => x.IsCheck == true).ToList(),
                ProductList = appDbContext.Products.Where(x => x.IsActive == true).ToList()
            };


            return View(homeVM);
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
        public IActionResult ShopGrid()
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
