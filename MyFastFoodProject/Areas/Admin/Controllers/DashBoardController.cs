using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFastFoodProject.DAL;
using MyFastFoodProject.Models;

namespace MyFastFoodProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DashBoardController : Controller
    {

        private readonly AppDbContext _appDbContext;
        private readonly SignInManager<ProgramUser> _signinmanager;
        public DashBoardController(AppDbContext appDbContext, SignInManager<ProgramUser> signInManager)
        {
            _appDbContext = appDbContext;
            _signinmanager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Logout()
        {

            await _signinmanager.SignOutAsync();
            return RedirectToAction("Index", "Home",new {area =""});
        }
    }
}