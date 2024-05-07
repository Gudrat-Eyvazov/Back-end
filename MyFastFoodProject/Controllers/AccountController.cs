using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFastFoodProject.DAL;
using MyFastFoodProject.Models;
using MyFastFoodProject.Models.ViewModels;

namespace MyFastFoodProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext appDbContext;
        private readonly UserManager<ProgramUser> _userManager;
        private readonly SignInManager<ProgramUser> _signinmanager;
        public AccountController(AppDbContext _appDbContext, UserManager<ProgramUser> userManager, SignInManager<ProgramUser> signinmanager)
        {
            appDbContext = _appDbContext;
            _userManager = userManager;
            _signinmanager = signinmanager;
        }
        [HttpPost]
        public async Task<ActionResult> SignUp(SignUpVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            ProgramUser programUser = new ProgramUser
            {
                Email = model.TestEmail,
                UserName = model.UserName
            };

            var result = await _userManager.CreateAsync(programUser, model.Password);
            if (result.Succeeded)
            {
                RedirectToAction("Index", "Home");
            }
            //foreach (var item in result.Errors)
            //{
            //}  

            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Login(LoginVM model)
        {
            
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "something wrong");
            }
            var User = await _userManager.FindByNameAsync(model.UserName);
            if (User != null)
            {
                var result = await _signinmanager.PasswordSignInAsync(User, model.Password, model.IsRemember, false);
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Password or UserName incorrect");
                }
                await _signinmanager.PasswordSignInAsync(User, model.Password, model.IsRemember, false);
            }
            return RedirectToAction("Index", "Home");

        }
        
        public async Task<IActionResult> Logout()
        {

            await _signinmanager.SignOutAsync();
            return RedirectToAction("Index", "Home");
            

        }
    }
}
