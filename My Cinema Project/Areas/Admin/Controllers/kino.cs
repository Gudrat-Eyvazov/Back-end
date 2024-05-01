using Microsoft.AspNetCore.Mvc;

namespace My_Cinema_Project.Areas.Admin.Controllers
{
    public class kino : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
