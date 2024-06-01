using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyFastFoodProject.DAL;
using MyFastFoodProject.Models;

namespace MyFastFoodProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext appDbContext;
        private readonly IWebHostEnvironment _env;
        public CategoryController(AppDbContext _appDbContext, IWebHostEnvironment env)
        {
            appDbContext = _appDbContext;
            _env = env;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.Category = appDbContext.Categories.ToList();

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Category  model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Category = appDbContext.Categories.ToList();
                return View(model);
            }
            appDbContext.Categories.Add(model);
            appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}